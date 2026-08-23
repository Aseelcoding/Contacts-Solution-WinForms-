using DataAccess;
using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Policy;


namespace BusinessLogic
{
   
    public class clsContact
    {
        enum EnMode { Add, Update }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ImagePath { get; set; }
        public int CountryID { get; set; }
       EnMode Mode { get; set; }
        public clsContact() 
        {
        
            Mode= EnMode.Add;
        }
        private clsContact(int ID,string FirstName, string LastName, string Email, string Phone, string Address, DateTime DateOfBirth, string ImagePath, int CountryID) 
        {
            this.ID = ID;   
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.ImagePath = ImagePath;
            this.CountryID = CountryID;
            this.Phone = Phone;
            this.Email=Email;
            Mode = EnMode.Update;
        }
        public static clsContact Find(int ID)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            int CountryID = -1;
            DateTime DateOfBirth = DateTime.Now;

            if (DataAccess.clsDataAccess.Find(ID, ref FirstName, ref LastName, ref Email, ref Phone, ref Address, ref DateOfBirth, ref CountryID, ref ImagePath))
            {
          
                return new clsContact(ID,FirstName, LastName, Email, Phone, Address, DateOfBirth, ImagePath, CountryID);
            }

            return null;
        }
        private bool _AddNewContact()
        {
          
            this.ID=DataAccess.clsDataAccess.AddContact(this.FirstName, this.LastName, this.Email, this.Phone, this.Address, this.DateOfBirth, this.CountryID, this.ImagePath);

            return (this.ID != -1);
        }
        private bool UpdateContact() 
        {
            

         
                return clsDataAccess.UpdateContact(this.ID, this.FirstName, this.LastName, this.Email, this.Phone, this.Address, this.DateOfBirth, this.CountryID, this.ImagePath);
         
        }
        public static bool DeleteContact (int ID)
        {

            if (IsContactExist(ID)) { return clsDataAccess.DeleteContact(ID); }
            else { return false; }
             
                
           
        }
        public static DataTable ListContacts() 
        {
       return DataAccess.clsDataAccess.ListContacts();
        }
        public static bool IsContactExist(int ID)
        {
            return clsDataAccess.IsContactExist(ID);
        }
        public bool Save() 
        {

            switch (Mode)
            {
                case EnMode.Add:
                    {
                        if (_AddNewContact())
                          { 
                            Mode= EnMode.Update;
                            return true;
                        }
                        else { return false; }
                    }
                case EnMode.Update:
                    {
                        

                        return UpdateContact();
                    }
            }
       
            return false;
        }
    }
    public class clsCountries
    {
         enum EnMode { Add, Update }
        public int ID {  get; set; }
        public string CountryName { get; set; }
        public string Code { get; set; }
        public string PhonCode { get; set; }

         EnMode Mode { get; set; }
            private clsCountries(int ID,string CountryName,string Code,string PhoneCode)
        {
            this.ID = ID;
            this.CountryName= CountryName;
            this.Code= Code;
            this.PhonCode= PhoneCode;
            this.Mode= EnMode.Update;

        }
       private  bool _AddCountry()
        {
           this.ID= clsDataAccess.AddCountry( this.CountryName,this.Code,this.PhonCode);
            if (this.ID != -1) {
                return true;
            }

            return false;
        }
        private bool UpdateCountry() 
        {
           if (IsCountryExistByID(this.ID))
            {
                return clsDataAccess.UpdateCountry(this.ID, this.CountryName,this.Code,this.PhonCode);
            }
           else 
                return false;
        }
        public static bool DeleteCountryByID(int ID) 
        {
            if (IsCountryExistByID(ID))
            {
                return clsDataAccess.DeleteCountryByID(ID);
            }
            else return false;
        }
        public static bool FindCountryByName(ref int ID, ref string CountryName) 
        {
            return clsDataAccess.FindCountryByName(ref ID, ref CountryName);
        }
        public static bool IsCountryExistByName(string CountryName)
        {
            return clsDataAccess.IsCountryExistByName(CountryName);
        }
        public static bool IsCountryExistByID(int ID)
        {
            return clsDataAccess.IsCountryExistByID(ID);    
        }
       public static DataTable ListCountries() 
        {
            return clsDataAccess.ListCountries();
        }
       public bool Save() 
        {

            switch (Mode) 
            {
                case EnMode.Add:
                    {
                        if (_AddCountry())
                        {
                            Mode= EnMode.Update; return true;
                        }
                       
                        break;
                    }


                case EnMode.Update:
                    {
                       if(UpdateCountry())
                        { return true; }

                        break;
                    }
            
            }

            return false;
        }
    }

}

using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Contacts_Solution__WinForms_
{
    public partial class FrmAddEdit : Form
    {
        public enum EnMode { Add,Update};

        private EnMode _Mode;
        int ContactID;
        string _ImagePath;

        private void ListCountriesInComBox() 
        {
            DataTable dataTable= clsCountries.ListCountries();

            foreach (DataRow row in dataTable.Rows) 
            {
                cmbCountries.Items.Add(row["CountryName"]);
            }

        }
        
        public FrmAddEdit(int ContactID)
        {
           InitializeComponent();

            if (ContactID ==-1)
            _Mode = EnMode.Add;
            else 
          { _Mode = EnMode.Update;this.ContactID = ContactID; }


            _Load();
        }
        private void GetAllInfo() 
        {
            clsContact contact = clsContact.Find(ContactID);

            labContactID.Text = contact.ID.ToString();
            txtFirstName.Text = contact.FirstName.ToString();
            txtLastName.Text = contact.LastName.ToString();
            txtPhone.Text = contact.Phone.ToString();
            txtEmail.Text = contact.Email.ToString();
            txtAddress.Text = contact.Address.ToString();
            dpDateOfBirth.Value = contact.DateOfBirth;
            string CountryName = "";
            clsCountries.FindCountryByID(contact.CountryID, ref CountryName);
            cmbCountries.SelectedItem = CountryName;
            if (contact.ImagePath != null)
          { 
                pbProfileImage.Image = System.Drawing.Image.FromFile(contact.ImagePath);
                _ImagePath = contact.ImagePath; 
            
            }


        }
        private void _Load() 
        {
            ListCountriesInComBox();


            switch (_Mode) 
            {
                case EnMode.Add:
                    {
                        labAddEdit.Text = "Adding New Contact";
                        labRemoveImage.Visible = false;
                        break;
                    }

                case EnMode.Update: 
                    {
                        labAddEdit.Text = "Updateing Contact";
                        GetAllInfo();
                        break;
                    }
            }
            
        }

        private void labSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _ImagePath = openFileDialog.FileName;
                    pbProfileImage.Image = System.Drawing.Image.FromFile(_ImagePath);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (_Mode)
            {
                case EnMode.Add:
                    {
                        clsContact contact = new clsContact();
                        contact.FirstName = txtFirstName.Text;
                        contact.LastName = txtLastName.Text;
                        contact.Email = txtEmail.Text;
                        contact.Phone = txtPhone.Text;
                        contact.DateOfBirth = dpDateOfBirth.Value;
                        if(pbProfileImage.Image!=null)
                        contact.ImagePath=_ImagePath;
                        contact.Address = txtAddress.Text;
                        int CountryId = 1; clsCountries.FindCountryByName(ref CountryId, cmbCountries.SelectedItem.ToString());
                        contact.CountryID = CountryId;

                        contact.Save();
                        ContactID = contact.ID;
                        _Mode = EnMode.Update;
                        _Load();
                        break;
                    }

                case EnMode.Update:
                    {
                        
                        clsContact contact = clsContact.Find(ContactID);
                        contact.FirstName = txtFirstName.Text;
                        contact.LastName = txtLastName.Text;
                        contact.Email = txtEmail.Text;
                        contact.Phone = txtPhone.Text;
                        contact.DateOfBirth = dpDateOfBirth.Value;
                        contact.ImagePath = _ImagePath;
                        contact.Address = txtAddress.Text;
                        int CountryId = 1; clsCountries.FindCountryByName(ref CountryId, cmbCountries.SelectedItem.ToString());
                        contact.CountryID = CountryId;

                        contact.Save();
                        this.Close();
                        break;
                    }
            }

       
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

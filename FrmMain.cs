using BusinessLogic;
using Microsoft.SqlServer.Server;
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

namespace Contacts_Solution__WinForms_
{
   
    public partial class FrmMain : Form
    {

        private void RefreshList() 
        {
            dgvAllContacts.DataSource = clsContact.ListContacts();
      
        }
        public FrmMain()
        {

     

            InitializeComponent();

        
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnAdding_Click(object sender, EventArgs e)
        {
            FrmAddEdit frmAdd = new FrmAddEdit(-1);   
            frmAdd.ShowDialog();
            RefreshList();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            int ContactID=(int)dgvAllContacts.CurrentRow.Cells[0].Value;
            if (clsContact.DeleteContact(ContactID))
            {
                MessageBox.Show("Done Successfully");
            }
            else
            {
                MessageBox.Show("Faild");
            }
            RefreshList();
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            int ContactID = (int)dgvAllContacts.CurrentRow.Cells[0].Value;
            FrmAddEdit frmEdit = new FrmAddEdit(ContactID);
            frmEdit.ShowDialog();
            RefreshList();

        }
    }
}

using ContactDll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactDll.Service;

namespace ContactAppUI
{
    public partial class ContactAppUi : Form
    {
        DataSet contactData;
        public ContactAppUi()
        {
            InitializeComponent();
           
            contactGridView.CellClick += new DataGridViewCellEventHandler(ContactGridView_CellClick);
        }


        private void AddContactBtn_Click(object sender, EventArgs e)
        {
            String contactName = name.Text;
            String contactNumber = contactNo.Text;
            String address = cAddress.Text;
            Guid guid = Guid.NewGuid();
            ContactWithAddress newContact = new ContactWithAddress(guid, contactName, contactNumber, address);
            ContactDb saveContact = new ContactDb();
            Boolean isContactAdded = saveContact.SaveContactDetails(newContact);
            if (isContactAdded)
            {
                MessageBox.Show("Contact Added!");
                return;
            }
            MessageBox.Show("Contact Not added");

        }

        private void DisplayContactBtn_Click(object sender, EventArgs e)
        {
            
            ContactsAccess display = new ContactsAccess();
            contactData = display.DisplayContactDetails();

            contactGridView.DataSource = contactData.Tables["empTable"];
            DataGridViewButtonColumn btn;
            btn = new DataGridViewButtonColumn();
            if (contactGridView.ColumnCount < 4)
            {
                
                contactGridView.Columns.Add(btn);
                btn.HeaderText = "Address";
                btn.Text = "Address";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
            } 

        }


        private void ContactGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            int columnNo=0;
            for (var i = 0; i < contactGridView.ColumnCount; i++)
            {
                var name = contactGridView.Columns[i].HeaderText;
                if (name == "CID")
                {
                    columnNo = i;
                }
                
            }
            id = contactGridView.Rows[e.RowIndex].Cells[columnNo].Value.ToString();
            AddressAccess displayAddress = new AddressAccess();
            String contactAddress = displayAddress.GetAddress(id);
            MessageBox.Show(contactAddress);
            

        }

        
    }
}

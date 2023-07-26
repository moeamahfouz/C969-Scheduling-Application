using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Scheduling_Application
{
    public partial class NewCustForm : Form
    {
        public NewCustForm()
        {
            InitializeComponent();
        }

        private void NewCustSave_Click(object sender, EventArgs e)
        {
            string timestamp = AppDatabase.LogTimeStamp();
            string userName = AppDatabase.GetUserName();
            if (string.IsNullOrEmpty(NewCustName.Text) || string.IsNullOrEmpty(NewCustPhone.Text) ||
                string.IsNullOrEmpty(NewCustStreet.Text) || string.IsNullOrEmpty(NewCustCity.Text) ||
                string.IsNullOrEmpty(NewCustZip.Text) || string.IsNullOrEmpty(NewCustCountry.Text) ||
                (NewCustActiveYes.Checked == false && NewCustActiveNo.Checked == false))
            {
                MessageBox.Show("Please fill in any blank fields.", "Error"); //Exception handler for ensuring there are no blank fields
            }
            else
            {
                int countryID = AppDatabase.NewLog(timestamp, userName, "country", $"'{NewCustCountry.Text}'");
                int cityID = AppDatabase.NewLog(timestamp, userName, "city", $"'{NewCustCity.Text}', '{countryID}'");
                int addressID = AppDatabase.NewLog(timestamp, userName, "address",
                    $"'{NewCustStreet.Text}', '', '{cityID}', '{NewCustZip.Text}', '{NewCustPhone.Text}'");
                AppDatabase.NewLog(timestamp, userName, "customer",
                    $"'{NewCustName.Text}', '{addressID}', '{(NewCustActiveYes.Checked ? 1 : 0)}'");

                MessageBox.Show("Customer has been added successfully.", "Success");

                Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NewCustCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

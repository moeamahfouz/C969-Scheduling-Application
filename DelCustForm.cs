using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C969_Scheduling_Application
{
    public partial class DelCustForm : Form
    {
        public DelCustForm()
        {
            InitializeComponent();
        }

        public static Dictionary<string, string> CustInfo = new Dictionary<string, string>();

        public bool DelCust() //Searches with Customer ID and deletes customer
        {
            MySqlConnection s = new MySqlConnection(AppDatabase.dbConnection);
            s.Open();

            string logDeletion = $"DELETE FROM customer" +
                                 $" WHERE customerName = '{CustInfo["customerName"]}'";
            MySqlCommand command = new MySqlCommand(logDeletion, s);
            int deletedCust = command.ExecuteNonQuery();

            logDeletion = $"DELETE FROM address" + $" WHERE address = '{CustInfo["address"]}'";
            command = new MySqlCommand(logDeletion, s);
            int deletedAddress = command.ExecuteNonQuery();

            logDeletion = $"DELETE FROM city" + $" WHERE city = '{CustInfo["city"]}'";
            command = new MySqlCommand(logDeletion, s);
            int deletedCity = command.ExecuteNonQuery();

            logDeletion = $"DELETE FROM country" + $" WHERE country = '{CustInfo["country"]}'";
            command = new MySqlCommand(logDeletion, s);
            int deletedCountry = command.ExecuteNonQuery();

            s.Close();

            if (deletedCust != 0 && deletedAddress != 0 && deletedCity != 0 && deletedCountry != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void DelCustSearch_Click(object sender, EventArgs e) //Search button functionality, finds customer based on ID.
        {
            int custID = AppDatabase.LookupCustomer(DelCustID.Text);

            if (custID != 0)
            {
                CustInfo = AppDatabase.GetCustInfo(custID);
                DelCustName.Text = CustInfo["customerName"];
                DelCustPhone.Text = CustInfo["phone"];
                DelCustStreet.Text = CustInfo["address"];
                DelCustCity.Text = CustInfo["city"];
                DelCustZip.Text = CustInfo["postalCode"];
                DelCustCountry.Text = CustInfo["country"];

                if (CustInfo["active"] == "True")
                {
                    DelCustActive.Text = "Yes";
                }
                else
                {
                    DelCustActive.Text = "No";
                }
            }
            else
            {
                MessageBox.Show("A customer with the ID you entered could not be found.", "Error");
            }
        }

        private void DelCustDel_Click(object sender, EventArgs e)
        {
            DialogResult DelCustConfirm = MessageBox.Show("Have all of this customer's appointments been deleted?",
                "Warning", MessageBoxButtons.YesNo);

            if (DelCustConfirm == DialogResult.Yes)
            {
                DelCust();
                MessageBox.Show("This customer has been deleted successfully.", "Success");
            }
            else
            {
                MessageBox.Show($"{CustInfo["customerName"]} could not be deleted.", "Error");
            }
        }

        private void DelCustCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

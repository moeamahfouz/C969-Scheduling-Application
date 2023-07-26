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
    public partial class UpdCustForm : Form
    {
        public UpdCustForm()
        {
            InitializeComponent();
        }

        public static Dictionary<string, string> UpdCustomer = new Dictionary<string, string>();


        private void UpdCustSearch_Click(object sender, EventArgs e) //Allows user to search customer by ID and returns all customer data.
        {
            int custID = AppDatabase.LookupCustomer(UpdCustID.Text);

            if (custID != 0)
            {
                UpdCustomer = AppDatabase.GetCustInfo(custID);
                UpdCustName.Text = UpdCustomer["customerName"];
                UpdCustPhone.Text = UpdCustomer["phone"];
                UpdCustStreet.Text = UpdCustomer["address"];
                UpdCustCity.Text = UpdCustomer["city"];
                UpdCustZip.Text = UpdCustomer["postalCode"];
                UpdCustCountry.Text = UpdCustomer["country"];

                if (UpdCustomer["active"] == "True")
                {
                    UpdCustActiveYes.Checked = true;
                }
                else
                {
                    UpdCustActiveNo.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("A customer with the ID you entered could not be located.", "Error");
            }
        }

        private void UpdCustSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UpdCustName.Text) || string.IsNullOrEmpty(UpdCustPhone.Text) ||
                string.IsNullOrEmpty(UpdCustStreet.Text) || string.IsNullOrEmpty(UpdCustCity.Text) ||
                string.IsNullOrEmpty(UpdCustZip.Text) || string.IsNullOrEmpty(UpdCustCountry.Text) ||
                (UpdCustActiveYes.Checked == false && UpdCustActiveNo.Checked == false))
            {
                MessageBox.Show("Please fill in any blank fields.", "Error");
            }
            else
            {
                Dictionary<string, string> saveUpds = new Dictionary<string, string>();

                saveUpds.Add("customerName", UpdCustName.Text);
                saveUpds.Add("phone", UpdCustPhone.Text);
                saveUpds.Add("address", UpdCustStreet.Text);
                saveUpds.Add("city", UpdCustCity.Text);
                saveUpds.Add("postalCode", UpdCustZip.Text);
                saveUpds.Add("country", UpdCustCountry.Text);
                saveUpds.Add("active", UpdCustActiveYes.Checked ? "1" : "0");

                UpdatedCustomer(saveUpds);
                MessageBox.Show("Customer has been successfully updated.", "Success");
                Close();
            }
        }
        public bool UpdatedCustomer(Dictionary<string, string> UpdForm) //Updates tables containing customer information.
        {
            MySqlConnection s = new MySqlConnection(AppDatabase.dbConnection);
            s.Open();

            string logUpdate = $"UPDATE customer" +
                               $" SET customerName = '{UpdForm["customerName"]}', active = '{UpdForm["active"]}', lastUpdate = '{AppDatabase.LogTimeStamp()}', lastUpdateBy = '{AppDatabase.GetUserName()}'" +
                               $" WHERE customerName = '{UpdCustomer["customerName"]}'";
            MySqlCommand command = new MySqlCommand(logUpdate, s);
            int UpdatedCust = command.ExecuteNonQuery();

            logUpdate = $"UPDATE address" +
                        $" SET address = '{UpdForm["address"]}', postalCode = '{UpdForm["postalCode"]}', phone = '{UpdForm["phone"]}', lastUpdate = '{AppDatabase.LogTimeStamp()}', lastUpdateBy = '{AppDatabase.GetUserName()}'" +
                        $" WHERE address = '{UpdCustomer["address"]}'";
            command = new MySqlCommand(logUpdate, s);
            int UpdatedAddress = command.ExecuteNonQuery();

            logUpdate = $"UPDATE city" +
                        $" SET city = '{UpdForm["city"]}', lastUpdate = '{AppDatabase.LogTimeStamp()}', lastUpdateBy = '{AppDatabase.GetUserName()}'" +
                        $" WHERE city = '{UpdCustomer["city"]}'";
            command = new MySqlCommand(logUpdate, s);
            int UpdatedCity = command.ExecuteNonQuery();

            logUpdate = $"UPDATE country" +
                        $" SET country = '{UpdForm["country"]}', lastUpdate = '{AppDatabase.LogTimeStamp()}', lastUpdateBy = '{AppDatabase.GetUserName()}'" +
                        $" WHERE country = '{UpdCustomer["country"]}'";
            command = new MySqlCommand(logUpdate, s);
            int UpdatedCountry = command.ExecuteNonQuery();
            s.Close();

            if (UpdatedCust != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void UpdCustCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

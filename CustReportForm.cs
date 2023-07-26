using System;
using System.Collections;
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
    public partial class CustReportForm : Form
    {
        public CustReportForm()
        {
            InitializeComponent();
            CustReport.DataSource = CustomerReport();
        }

        public static DataTable CustomerReport()
        {
            Dictionary<int, Hashtable> numAppointments = AppDatabase.GetAppointments();

            DataTable custDataTable = new DataTable();

            custDataTable.Clear();
            custDataTable.Columns.Add("Customer Name");
            custDataTable.Columns.Add("Number of Appointments");

            IEnumerable<string>
                y = numAppointments.Select(i => i.Value["customerName"].ToString())
                    .Distinct(); 

            foreach (string x in y)
            {
                DataRow row = custDataTable.NewRow();
                row["Customer Name"] = x;

                row["Number of Appointments"] = numAppointments
                    .Where(i => i.Value["customerName"].ToString() == x.ToString()).Count()
                    .ToString(); //Lambda function that displays the number of appointments a customer has next to their name.

                custDataTable.Rows.Add(row);
            }

            return custDataTable;
        }
    }
}

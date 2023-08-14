using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace C969_Scheduling_Application
{
    internal class AppDatabase
    {
        private static Dictionary<int, Hashtable> _appointmentDict = new Dictionary<int, Hashtable>();
        private static int _userID;
        private static string _userName;
        public static string dbConnection = "server=127.0.0.1;Port=3306;database=client_schedule;uid=sqlUser;pwd=Passw0rd!;";

        public static int GetUserID()
        {
            return _userID;
        }

        public static void SetUserID(int userID)
        {
            _userID = userID;
        }

        public static string GetUserName()
        {
            return _userName;
        }

        public static void SetUserName(string userName)
        {
            _userName = userName;
        }

        public static Dictionary<int, Hashtable> GetAppointments()
        {
            return _appointmentDict;
        }

        public static void SetAppointments(Dictionary<int, Hashtable> appointments)
        {
            _appointmentDict = appointments;
        }

        public static int NewUserID(List<int> iDList)
        {
            int firstID = 0;

            foreach (int id in iDList)
            {
                if (id > firstID)
                {
                    firstID = id;
                }
            }
            return firstID + 1;
        }

        public static string LogTimeStamp()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static int MakeID(string idtable) //This makes an ID for new entries.
        {
            MySqlConnection s = new MySqlConnection(dbConnection);
            s.Open();
            MySqlCommand command = new MySqlCommand($"SELECT {idtable + "ID"} FROM {idtable}", s);
            MySqlDataReader reader = command.ExecuteReader();
            List<int> idList = new List<int>();
            while (reader.Read())
            {
                idList.Add(Convert.ToInt32(reader[0]));
            }
            reader.Close();
            s.Close();
            return NewUserID(idList);
        }

        public static int NewLog(string timestamp, string userName, string table, string poq, int userID = 0) //This logs information upon a new entry
        {
            int logID = MakeID(table);
            string defaultName = "not needed";
            string logInsert;
            if (userID == 0)
            {
                logInsert = $"INSERT INTO {table}" +
                            $" VALUES ('{logID}', {poq}, '{timestamp}', '{userName}', '{timestamp}', '{userName}')";
            }
            else
            {
                logInsert =

                //I had to use this code before in order to properly save entries since the "not needed" columns weren't nulled. I have dropped the "not needed" columns from the database in order to clean up my code and prevent issues.

                //$"INSERT INTO {table} (appointmentID, customerID, start, end, type, userId, createDate, createdBy, lastUpdate, lastUpdateBy, title, description, location, contact, url)" +
                //$" VALUES ('{logID}', {poq}, '{userId}', '{timestamp}', '{userName}', '{timestamp}', '{userName}', '{defaultName}', '{defaultName}', '{defaultName}', '{defaultName}', '{defaultName}')";

                $"INSERT INTO {table} (appointmentID, customerID, start, end, type, userID, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                    $" VALUES ('{logID}', {poq}, '{userID}', '{timestamp}', '{userName}', '{timestamp}', '{userName}')";
            }

            MySqlConnection s = new MySqlConnection(dbConnection);
            s.Open();
            MySqlCommand command = new MySqlCommand(logInsert, s);
            command.ExecuteNonQuery();
            s.Close();

            return logID;
        }

        public static int LookupCustomer(string enterCust) //This allows users to look up customers in search bars using the customerId.
        {
            int custID;
            string query;
            if (int.TryParse(enterCust, out custID))
            {
                query = $"SELECT customerId FROM customer WHERE customerId = '{enterCust.ToString()}'";
            }
            else
            {
                query = $"SELECT customerId FROM customer WHERE customerName LIKE '{enterCust}'";
            }

            MySqlConnection s = new MySqlConnection(AppDatabase.dbConnection);
            s.Open();
            MySqlCommand command = new MySqlCommand(query, s);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                custID = Convert.ToInt32(reader[0]);
                reader.Close();
                s.Close();
                return custID;
            }

            return 0;
        }

        public static Dictionary<string, string> GetCustInfo(int custID) //This retrieves customer information when called.
        {
            string query = $"SELECT * FROM customer WHERE customerId = '{custID.ToString()}'";
            MySqlConnection s = new MySqlConnection(AppDatabase.dbConnection);
            s.Open();
            MySqlCommand command = new MySqlCommand(query, s);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            //Basic customer info

            Dictionary<string, string> customerDict = new Dictionary<string, string>();
            customerDict.Add("customerName", reader[1].ToString());
            customerDict.Add("addressID", reader[2].ToString());
            customerDict.Add("active", reader[3].ToString());
            reader.Close();

            query = $"SELECT * FROM address WHERE addressID = '{customerDict["addressID"]}'";
            command = new MySqlCommand(query, s);
            reader = command.ExecuteReader();
            reader.Read();

            //Customer address info

            customerDict.Add("address", reader[1].ToString());
            customerDict.Add("cityID", reader[3].ToString());
            customerDict.Add("postalCode", reader[4].ToString());
            customerDict.Add("phone", reader[5].ToString());
            reader.Close();

            query = $"SELECT * FROM city WHERE cityID = '{customerDict["cityID"]}'";
            command = new MySqlCommand(query, s);
            reader = command.ExecuteReader();
            reader.Read();

            //Customer city info

            customerDict.Add("city", reader[1].ToString());
            customerDict.Add("countryId", reader[2].ToString());
            reader.Close();

            query = $"SELECT * FROM country WHERE countryID = '{customerDict["countryID"]}'";
            command = new MySqlCommand(query, s);
            reader = command.ExecuteReader();
            reader.Read();

            //Customer country info

            customerDict.Add("country", reader[1].ToString());
            reader.Close();
            s.Close();

            return customerDict;
        }

        public static Dictionary<string, string> GetAppInfo(string appID) //Retrieves appointment information when called.
        {
            string query = $"SELECT * FROM appointment WHERE appointmentID = '{appID}'";
            MySqlConnection s = new MySqlConnection(AppDatabase.dbConnection);
            s.Open();
            MySqlCommand command = new MySqlCommand(query, s);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            //Customer appointment information

            Dictionary<string, string> appointmentDict = new Dictionary<string, string>();
            appointmentDict.Add("appointmentID", appID);
            appointmentDict.Add("customerId", reader[1].ToString());
            appointmentDict.Add("type", reader[3].ToString());
            appointmentDict.Add("start", reader[7].ToString());
            appointmentDict.Add("end", reader[8].ToString());
            reader.Close();

            return appointmentDict;
        }

        public static string TimezoneConversion(string dateTime) //This converts time based on timezone of user.
        {
            DateTime utcDateTime = DateTime.Parse(dateTime);
            DateTime localDateTime = utcDateTime.ToLocalTime();

            return localDateTime.ToString("MM/dd/yyyy hh:mm tt");
        }
    }
}

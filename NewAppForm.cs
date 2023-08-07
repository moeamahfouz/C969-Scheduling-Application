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
    public partial class NewAppForm : Form
    {
        public NewAppForm()
        {
            InitializeComponent();
            NewAppEnd.Value = NewAppEnd.Value.AddHours(2); //Defaults the "Appointment End" box to two hours from set time
        }

        public HomeForm HomeNewApp; //Connects to function that opens this form


        private void NewAppSave_Click(object sender, EventArgs e) //Save button for Add Appointment page.
        {
            string timestamp = AppDatabase.LogTimeStamp();
            int userid = AppDatabase.GetUserID();
            string username = AppDatabase.GetUserName();
            DateTime startTime = NewAppStart.Value.ToUniversalTime();
            DateTime endTime = NewAppEnd.Value.ToUniversalTime();

            try
            {
                if (AppointConflict(startTime, endTime)) //This will prevent appointments from being scheduled if the set times conflict with another appointment.
                    throw new AppExceptions();

                else
                {
                    try
                    {
                        if (BusinessHourConflict(startTime, endTime)) //This will prevent appointments from being scheduled outside of business hours.
                        {
                            throw new AppExceptions();
                        }
                        else
                        {
                            AppDatabase.NewLog(timestamp, username, "appointment",
                                $"'{NewAppCustID.Text}', '{NewAppStart.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}', '{NewAppEnd.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss")}', '{NewAppType.Text}'", //Saves start and end dates in proper MySQL date format.
                                userid);
                            HomeNewApp.HomeCalUpdate(); //Updates homepage calendar to reflect appointment changes.

                            MessageBox.Show("Appointment successfully created.", "Success");
                            Close();
                        }
                    }
                    catch (AppExceptions ex)
                    {
                        ex.BusinessHours();
                    }
                }
            }
            catch (AppExceptions ex)
            {
                ex.AppConflict();
            }
        }
        public static bool AppointConflict(DateTime startTime, DateTime endTime) //This defines the previous function that prevents appointments from being created if the time conflicts with another already-set appointment.
        {
            foreach (var app in AppDatabase.GetAppointments().Values)
            {
                if (startTime < DateTime.Parse(app["end"].ToString()) &&
                    DateTime.Parse(app["start"].ToString()) < endTime)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool BusinessHourConflict(DateTime startTime, DateTime endTime) //This defines the previous function that prevents and appointment from being created outside of business hours.
        {
            startTime = startTime.ToLocalTime();
            endTime = endTime.ToLocalTime();
            DateTime openTime = DateTime.Today.AddHours(8);
            DateTime closeTime = DateTime.Today.AddHours(17);

            if (startTime.TimeOfDay > openTime.TimeOfDay && startTime.TimeOfDay < closeTime.TimeOfDay &&
                endTime.TimeOfDay > openTime.TimeOfDay && endTime.TimeOfDay < closeTime.TimeOfDay)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void NewAppCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Scheduling_Application
{
    class AppExceptions : Exception
    {
        public void AppConflict()
        {
            MessageBox.Show("There is already an appointment that falls within the time you're choosing, please choose a different time.",
                "Error");
        }

        public void BusinessHours()
        {
            MessageBox.Show("This appointment falls outside of business hours, please choose a different time and try again.", "Error");
        }


    }
}

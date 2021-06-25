using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject.Models
{
    public class Admin : Staff
    {
        //Fields
        private const float overtimeRate = 15.5F;
        private const float adminHourlyRate = 30;

        //Properties
        public float Overtime { get; private set; }

        //Constructor
        public Admin(string name)
            : base(name, adminHourlyRate)
        {
        }
        //Methods
        public override void CalculatePay()
        {
            base.CalculatePay();
            Overtime = 0;
            if(HoursWorked > 160)
            {
                Overtime = overtimeRate * (HoursWorked - 160);
            }
            TotalPay = TotalPay + Overtime;
        }

        public override string ToString()
        {
            string returnString = "Name of Staff: " + NameOfStaff + ", Hourly Rate: " + adminHourlyRate + ", Hours Worked:" + HoursWorked + ", Basic Pay: " + BasicPay + ", Total Pay: " + TotalPay + ".";
            return returnString;
        }
    }

}

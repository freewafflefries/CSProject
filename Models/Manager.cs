using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject.Models
{
    public class Manager : Staff
    {
        //Fields
        private const float managerHourlyRate = 50;
        
        //Properties
        public int Allowance { get; private set; }
        
        //Constructor
        public Manager(string name)
            : base( name,  managerHourlyRate)
        { 
        }

        //Methods
        public override void CalculatePay()
        {
            base.CalculatePay();
            Allowance = 1000;

            if (HoursWorked > 160)
            {
                TotalPay = TotalPay + Allowance;
            };
        }

        public override string ToString()
        {
            string returnString = "Name of Staff: " + NameOfStaff + ", Hourly Rate: " + managerHourlyRate + ", Allowance: " + Allowance + ", Hours Worked:" + HoursWorked + ", Basic Pay: " + BasicPay + ", Total Pay: " + TotalPay + ".";
            return returnString;
        }
    }
}

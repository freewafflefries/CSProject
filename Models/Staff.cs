using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject.Models
{
    public class Staff
    {
        //Fields
        private float hourlyRate;
        private int hWorked;

        //Properties
        public float TotalPay { get; protected set; }
        public float BasicPay { get; private set; }
        public string NameOfStaff { get; private set; }

        public int HoursWorked 
        {   get { return hWorked; }
            set 
            { 
                if (value < 0)
                    hWorked = 0;
                else
                    hWorked = value;
            }
        }

        //Constructor

        public Staff(string name, float rate)
        {
            hourlyRate = rate;
            NameOfStaff = name;
        }

        //Methods
        public virtual void CalculatePay()
        {
            Console.WriteLine("Calculating Pay...");

            var calculatedPay = hourlyRate * hWorked;
            BasicPay = calculatedPay;
            TotalPay = calculatedPay;
        }

        public override string ToString()
        {
            string returnString = "Name of Staff: " + NameOfStaff + ", Hourly Rate: " + hourlyRate + ", Hours Worked:" + HoursWorked + ", Basic Pay: " + BasicPay + ", Total Pay: " + TotalPay + ".";
            return returnString;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2Library
{
    public class Accountant : IApplicationHandler
    {
        public decimal ScholarshipFund { get; set; }

        public Accountant(decimal scholarshipFund)
        {
            ScholarshipFund = scholarshipFund;
        }

        public void SetNextHandler(IApplicationHandler handler)
        {
            
        }

        public void ProcessApplication(StudentApplication application)
        {
            decimal scholarshipAmount;

            if (application.GPA > 9.0)
            {
                scholarshipAmount = 50000000m;
            }
            else if (application.GPA > 8.5)
            {
                scholarshipAmount = 20000000m;
            }
            else if (application.GPA > 8.0)
            {
                scholarshipAmount = 10000000m;
            }
            else
            {
                scholarshipAmount = 0m;
            }


            if (ScholarshipFund >= scholarshipAmount)
            {
                Console.WriteLine("Accountant: Scholarship fund sufficient. Transferring scholarship.");
                ScholarshipFund -= scholarshipAmount;
            }
            else
            {
                Console.WriteLine("Accountant: Insufficient funds. Deducting from tuition fees.");
            }
        }
    }

}

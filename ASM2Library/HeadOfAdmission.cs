using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2Library
{
    public class HeadOfAdmission : IApplicationHandler
    {
        private IApplicationHandler _next;

        public void SetNextHandler(IApplicationHandler handler)
        {
            _next = handler;
        }

        public void ProcessApplication(StudentApplication application)
        {
            if (application.GPA > 9.0)
            {
                Console.WriteLine("HeadOfAdmission: Eligible for 50 million VND scholarship.");
                _next?.ProcessApplication(application);
            }
            else if (application.GPA > 8.5)
            {
                Console.WriteLine("HeadOfAdmission: Eligible for 20 million VND scholarship.");
                _next?.ProcessApplication(application);
            }
            else if (application.GPA > 8.0)
            {
                Console.WriteLine("HeadOfAdmission: Eligible for 10 million VND scholarship.");
                _next?.ProcessApplication(application);
            }
            else
            {
                Console.WriteLine("HeadOfAdmission: Not eligible for a scholarship.");
            }
        }
    }

}

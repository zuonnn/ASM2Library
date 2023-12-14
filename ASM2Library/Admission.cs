using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2Library
{
    public class Admission : IApplicationHandler
    {
        private IApplicationHandler _next;

        public void SetNextHandler(IApplicationHandler handler)
        {
            _next = handler;
        }

        public void ProcessApplication(StudentApplication application)
        {
            if (application.GPA > 7.0)
            {
                Console.WriteLine("Admission: Application approved.");
                _next?.ProcessApplication(application);
            }
            else
            {
                Console.WriteLine("Admission: Application rejected due to low GPA.");
            }
        }
    }

}

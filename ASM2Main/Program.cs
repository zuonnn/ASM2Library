using ASM2Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize the handlers
            var admission = new Admission();
            var headOfAdmission = new HeadOfAdmission();
            var accountant = new Accountant(100000000); // Initialize with a scholarship fund amount

            // Set the chain of responsibility
            admission.SetNextHandler(headOfAdmission);
            headOfAdmission.SetNextHandler(accountant);

            // Create a student application
            var studentApplication = new StudentApplication("Jane Doe", new DateTime(2000, 6, 15), 8.2, 9.1, 7.8);

            // Start the process
            admission.ProcessApplication(studentApplication);

            // Keep the console window open
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2Library
{
    public class StudentApplication
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Math { get; set; }
        public double Literature { get; set; }
        public double English { get; set; }
        public double GPA => (Math + Literature + English) / 3;

        public StudentApplication(string fullName, DateTime dateOfBirth, double math, double literature, double english)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Math = math;
            Literature = literature;
            English = english;
        }
    }

}

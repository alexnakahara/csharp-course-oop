using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    class Bedroom
    {
        public string StudentName { get; set; }
        public string Email { get; set; }

        public Bedroom(string studentName, string email)
        {
            StudentName = studentName;
            Email = email;
        }
    }
}

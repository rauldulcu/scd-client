using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public Department department { get; set; }
        public Employee? manager { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}

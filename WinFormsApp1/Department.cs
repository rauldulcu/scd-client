﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Department
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Department? parent { get; set; }
    }
}

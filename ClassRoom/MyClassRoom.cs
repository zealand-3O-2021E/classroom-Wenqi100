﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassRoom
{
    /*
    Task 2:
    Add a new class of "ClassRoom", with the following properties.

    string Class Name
    List \ Class list
    Datetime Semester Start
    Create a default constructor.
    */

    public class MyClassRoom
    {
        public string ClassName { get; set; }
        public List<string> ClassList { get; set; }
        public DateTime SemesterStart { get; set; }

        public MyClassRoom()
        {

        }
    }
}

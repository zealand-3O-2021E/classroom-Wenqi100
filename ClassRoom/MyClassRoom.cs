using System;
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
    Task 2: Add a new class of "ClassRoom", with the following properties.
    string Class Name
    List \ Class list
    Datetime Semester Start
    Create a default constructor.
    */

    public class MyClassRoom
    {
        private string v;
        private DateTime start;

        public string ClassName { get; set; }
        public List<string> ClassList { get; set; }
        public DateTime SemesterStart { get; set; }

        public MyClassRoom()
        {

        }

        public MyClassRoom(string className, List<string> classList, DateTime start)
        {
            this.ClassName = className;
            ClassList = classList;
            this.SemesterStart = start;
        }

        /* Task 4: Print out the information that is on your classroom object via console.WriteLine ()  */
        public string Print()
        {
            return ClassName + "\n" +
                   string.Join("\n", ClassList.ToArray()) + "\n" +
                   SemesterStart.ToString("yyyy MM dd");
        }
    }
}
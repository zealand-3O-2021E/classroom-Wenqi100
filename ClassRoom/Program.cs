using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Task 3
            We must now add some data. We do this in the Main method.
            Create an new instance of the ClassRoom class
            Fx: Class Name: 3Q, Beginning of the semester: 26-8-2019
            Add yourself and those you sit next to in the list of students
           */

            List<string> ClassList = new List<string>();
            ClassList.Add("Wenqi");
            ClassList.Add("Niko");
            ClassList.Add("Sarah");

            DateTime start = new DateTime(2019, 08, 26);

            MyClassRoom myClassRoom = new MyClassRoom("3Q",ClassList,start);
        
        }
    }
}
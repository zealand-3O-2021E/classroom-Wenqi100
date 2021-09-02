using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    /* Task 1: 
     * Add a class (public) "Student" with three properties: name, birth month and birthday. 
     * You also must have a constructor that takes three parameters.
    */
    
    public class Student
    {
        public string Name { get; set; }
        public int BirthMonth { get; set; }
        public int BirthDay { get; set; }
        public Student(string name, int month, int day)
        {
            Name = name;
            BirthMonth = month;
            BirthDay = day;
        }
    }
}

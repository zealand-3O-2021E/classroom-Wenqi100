using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    /* Task 1:
       Add a class (public) "Student", it must contain three properties. 
       These three properties must be visible outside of class but can only be set within this class.
       string name
       int birth month
       int birthday
   You also must have a constructor that takes three parameters so you can put your properties.
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

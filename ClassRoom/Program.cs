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
            Create an new instance of the ClassRoom class in the Main method
            Fx: Class Name: 3Q, Beginning of the semester: 26-8-2019
            Add yourself and those you sit next to in the list of students
           */

            List<string> ClassList = new List<string>();
            ClassList.Add("Wenqi");
            ClassList.Add("Niko");
            ClassList.Add("Sarah");

            DateTime start = new DateTime(2019, 08, 26);

            MyClassRoom myClassRoom = new MyClassRoom("3Q",ClassList,start);

            /* Task 4: Print out the information that is on your classroom object via console.WriteLine ()  */

            Console.WriteLine(myClassRoom.Print());
            Console.ReadLine();

            /* Task 6 Call the Count method.  */
            List<int> birthMonths = new List<int>();
            birthMonths.Add(1);
            birthMonths.Add(2);
            birthMonths.Add(3);
            birthMonths.Add(4);
            birthMonths.Add(5);
            birthMonths.Add(6);
            birthMonths.Add(7);
            birthMonths.Add(8);
            birthMonths.Add(9);
            birthMonths.Add(10);
            birthMonths.Add(11);
            birthMonths.Add(12);
            birthMonths.Add(2);
            birthMonths.Add(5);
            birthMonths.Add(7);
            birthMonths.Add(8);
            birthMonths.Add(11);
            //birthMonth.Add(15);

            Helper helper = new Helper();

            foreach (int i in birthMonths)
            {
                Console.WriteLine(helper.Season(i));
            }

            helper.Count(birthMonths);
            Console.ReadLine();
        }
    }
}

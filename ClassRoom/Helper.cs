using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Helper
    {
        /*Task 5 
          There must now be implemented a method "season" the returntype is a string. 
          The methods returns what season for the student's birthday.  
        */

        public string Season(int birthMonth)
        {
            string season = "Not identifiable";
            if (birthMonth == 12 || birthMonth == 1 || birthMonth == 2)
            {
                season = "Winter";
            }

            if(birthMonth == 3 || birthMonth == 4 || birthMonth == 5)
            {
                season = "Spring";
            }

            if(birthMonth == 6 || birthMonth == 7 || birthMonth == 8)
            {
                season = "Summer";
            }

            if(birthMonth == 9 || birthMonth == 10 || birthMonth == 11) 
            {
                season = "Autumn";
            }

            return season;
        }

        /* Task 6 To implemented a method to count how many have birthday in each season. 
                  This method does not return anything, but just write the result out in the console
                  Call the method.         
        */

        public void Count(List<int>birthMonths)
        {
            //int mistake = (from birthMonth in birthMonths
            //               where birthMonth > 12 || birthMonth < 1
            //               select birthMonth).Count();

            int springCount = (from birthMonth in birthMonths
                               where 2 < birthMonth && birthMonth < 6
                               select birthMonth).Count();
            int summerCount = (from birthMonth in birthMonths
                               where 5 < birthMonth && birthMonth < 9
                               select birthMonth).Count();
            int autumnCount = (from birthMonth in birthMonths
                               where 8 < birthMonth && birthMonth < 12
                               select birthMonth).Count();
            int winterCount = (from birthMonth in birthMonths
                               where birthMonth == 1 || birthMonth == 2 || birthMonth == 12
                               select birthMonth).Count();

            Console.WriteLine($"{springCount} stundets birth in Spring. " + "\n" +
                              $"{summerCount} stundets birth in Summer. " + "\n" +
                              $"{autumnCount} stundets birth in Autumn. " + "\n" +
                              $"{winterCount} stundets birth in Winter.");        
        }
    }
}

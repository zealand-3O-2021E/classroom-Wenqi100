using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Methods
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


    }
}

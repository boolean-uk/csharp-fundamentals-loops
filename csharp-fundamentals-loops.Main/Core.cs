using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_fundamentals_loops.Main
{
    public class Core
    {
        public int[] numsZeroToThree = new int[4];
        public int[] numsFiveToTen = new int[6];
        public int[] countdown = new int[4];

        public int[] favouriteNumbers = { 1, 2, 4, 5, 7, 8, 10 };

        public string[] myHobbies = { "Fishing", "Language learning", "Skydiving", "Procrastinating" };

        public void stepOne()
        {
            for (int i = 0; i <= 3; i++)
            {
                numsZeroToThree[i] = i;
            }
            // TODO: 1. Write a for loop that adds the numbers 0 to 3 to the numsZeroToThree array                        
        }

        public void stepTwo()
        {
            for (int i = 0; i < 6; i++)
            {
                numsFiveToTen[i] = i + 5;
            }
            // TODO: 2. Write a for loop that adds the numbers 5 to 10 to the numsFiveToTen array

        }

        public void stepThree()
        {
            int num = 3;
            for (int i = 0; i < 4; i++)
            {

                countdown[i] = num;
                num--;
            }
            // TODO: 3. Write a for loop that adds the numbers 3 to 0 (in that order) to the countdown arra
        }

        public bool stepFour(int num)
        {
            for (int i = 0; i < favouriteNumbers.Length; i++)
            {
                if (num == favouriteNumbers[i])
                {
                    return true;
                }
            }
            return false;
            // TODO: 6. Write a for loop that checks if num is in the favouriteNumbers array            
        }

        public bool stepFive(string hobby)
        {
            for (int i = 0; i < myHobbies.Length; i++)
            {
                if (hobby.Equals(myHobbies[i]))
                {
                    return true;
                }
            }
            return false;
            // TODO 5. Write a for loop that checks if the hobby String is in the myHobbies array
            throw new NotImplementedException();
        }
    }

}

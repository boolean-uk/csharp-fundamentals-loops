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
        public int[] numsZeroToThree= new int[4];
        public int[] numsFiveToTen = new int[6];
        public int[] countdown = new int[4];

        public int[] favouriteNumbers = { 1, 2, 4, 5, 7, 8, 10 };

        public string[] myHobbies = { "Fishing", "Language learning", "Skydiving", "Procrastinating" };

        public void stepOne()
        {
            for (int i = 0; i < 4; i++)
            {
                numsZeroToThree[i] = i;
            }
        }

        public void stepTwo()
        {
            for (int i = 0; i < 6; i++)
            {
                numsFiveToTen[i] = i+5;
            }
        }

        public void stepThree()
        {
            for (int i = 3; i >= 0; i--)
            {
                countdown[3 - i] = i;
            }

        }

        public bool stepFour(int num)
        {
            for (int i = 0; i < favouriteNumbers.Length; i++)
            {
                if (favouriteNumbers[i] == num)
                {
                    return true;
                }
            }

           return false;
        }

        public bool stepFive(string hobby)
        {
            for (int i = 0; i < myHobbies.Length; i++)
            {
                if (myHobbies[i] == hobby)
                {
                    return true;
                }
            }

            return false;
        }
    }

}

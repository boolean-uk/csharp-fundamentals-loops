using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            // TODO: 1. Write a for loop that adds the numbers 0 to 3 to the numsZeroToThree array                        
            //throw new NotImplementedException();
            for (int i = 0; i < numsZeroToThree.Length; i++)
            {
                numsZeroToThree[i] = i;
            }
        }

        public void stepTwo()
        {
            // TODO: 2. Write a for loop that adds the numbers 5 to 10 to the numsFiveToTen array
            //throw new NotImplementedException();
            int number = 5;
            for (int i = 0;i < numsFiveToTen.Length; i++)
            {
                numsFiveToTen[i] = number;
                number++;
            }
        }

        public void stepThree()
        {
            // TODO: 3. Write a for loop that adds the numbers 3 to 0 (in that order) to the countdown array
            //throw new NotImplementedException();
            int num = 0;
            for (int i = countdown.Length -1; i >= 0  ; i--) 
            {
                countdown[i] = num;
                num++;  
            }

        }

        public bool stepFour(int num)
        {
            // TODO: 6. Write a for loop that checks if num is in the favouriteNumbers array            
            //throw new NotImplementedException();
            bool isFavouriteNumber = false;
            foreach (int number in favouriteNumbers)
            {
                if (number == num)
                {
                    isFavouriteNumber = true;
                }
                
            }
            return isFavouriteNumber;
        }

        public bool stepFive(string hobby)
        {
            // TODO 5. Write a for loop that checks if the hobby String is in the myHobbies array
            //throw new NotImplementedException();
            bool isInArray = false;
            foreach(string Hobby in myHobbies)
            {
                if(Hobby == hobby)
                {
                    isInArray = true;
                }
                
            }
            return isInArray;  
        }
    }

}

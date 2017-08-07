using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Stat
    {
        Random rnd = new Random(); //Generate random numbers
        private int[] numbers;  //Hold random numbers
        TestNumber testN = new TestNumber();  //Class to test the validity of input number
        Boolean valid = false; //boolean if value is between 5 and 20 

        public string GenerateNumbers(int n)
        {
            bool isInt = (n % 1 == 0);
            if (!isInt)
                throw new FormatException();

            valid = testN.testNum(n); //call method with the input value
            string lNumbers = ""; //Message with the random numbers chosen
            if (valid)  //input value is between 5 and 20
            {
                numbers = new int[n];
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rnd.Next(1, 50);
                    lNumbers += numbers[i] + " ";
                }
            }
            else
            {
                lNumbers = "The value has to be between 5 and 20";
            }
            return lNumbers;
        }

        public int getMax()
        {
            int max = 0;
            if (valid)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > max)
                        max = numbers[i];
                }
            }
            else
                max = -1;
            return max;
        }
    }
}

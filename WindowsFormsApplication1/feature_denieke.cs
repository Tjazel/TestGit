using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class feature_denieke
    {
        Random rnd = new Random(); //Generate random numbers
        private int[] numbers;  //Hold random numbers

        public string GenerateNumbers(int n)
        {
            string lNumbers = ""; //Message with the random numbers chosen
            numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 50);
                lNumbers += numbers[i] + " ";
            }
           
            return lNumbers;
        }

        public int getMax()
        {
            int max = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > max)
                        max = numbers[i];
                }
           
            return max;
        }
    }
}

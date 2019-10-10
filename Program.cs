using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_array_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter the length of an array.");
            string giveANumber = Console.ReadLine();
            int arrNumber = Convert.ToInt32(giveANumber);
            int[] ar = new int[arrNumber];
            int number;
            int i = 0;

            Console.WriteLine("Please enter a number from 1 to 10, follow by the enter key.");
            do
            {
                string eachNumber = Console.ReadLine();
                //check to see if eachNumber contains string
                //will give a value to array only if input is integer
                bool ifNumber = Int32.TryParse(eachNumber, out number);
                if (ifNumber)
                {
                    ar[i] = number;
                    i++;
                }
            }
            while (i < arrNumber);
            Console.WriteLine($"The sum of total number is {simpleArraySum(ar)}.");
            SortedArr(ar);

        } // end of Main


        static int simpleArraySum(int[] arr)    
        {

            int sum = 0;
            foreach (int element in arr)
            {
                sum += element;
            }
            return sum;

        }

        static void SortedArr(int[] arr)
        {
            //Sort array in ascending order. 
            Array.Sort(arr);
            // Using Join method 
            // Here separator is ', '( comma ) 
            string sortedArrayList = string.Join(",", arr);
            Console.WriteLine($"The sorted array is [{sortedArrayList}]");

        }

    }

}


using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Swapping
    {
        //Swap between 2 numbers.
        int number1 = 15;
        int number2 = 20;
        int temp;

        //swap between 2 string
        string str1 = "Deepak";
        string str2 = "Sahu";

        public void SwapNumbersWithTempVariable()
        {
            Console.WriteLine(number1 + " " + number2);
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine(number1 + " " + number2);
        }

        //Swap between 2 number without using 3rd variable.

        // using * and /
        public void SwapNumbersWithoutTempVariable()
        {
            Console.WriteLine($"Before swapping {number1} and {number2}");

            number1 = number1 * number2;
            number2 = number1 / number2;
            number1 = number1 / number2;
            Console.WriteLine($"After swapping {number1} and {number2}");
        }

        //using + and -
        public void SwapNumbersWithoutTempVariable2()
        {
            Console.WriteLine($"Before swapping {number1} and {number2}");

            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.WriteLine($"After swapping {number1} and {number2}");
        }

        public void SwapStringWithoutTempVariable()
        {
            Console.WriteLine($"Before swapping {str1} and {str2}");
            // Append the 2nd string with the 1st string
            str1 = str1 + str2;
            // Call the substring method and  pass the strat index and lenght
            //Step2: store intial string name1 in string name2 
            str2 = str1.Substring(0, str1.Length - str2.Length);
            //Step3:  store initial string name2 in string name1
            str1 = str1.Substring(str2.Length);
            Console.WriteLine($"After swapping {str1} and {str2}");
        }
    }
}

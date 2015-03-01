using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Four_Digit_Number
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            int number = 0; 
            while (number.ToString().Length != 4)
            {
                Console.Write("Enter a number:");
                number = int.Parse(Console.ReadLine());
            }

            int fourthDigit = number % 10;
            int thirdDigit = number / 10 % 10;
            int secondDigit = number / 100 % 10;
            int firstDigit = number / 1000;

            //Put last digit to first position
            int lastDigitToFirstPositionNumber = fourthDigit * 1000 + number / 10;

            //Exchange the second and the third digit
            int excahangeDigitsInNumber = firstDigit * 1000 + thirdDigit * 100 + secondDigit * 10 + fourthDigit;

            //Reverse number
            int reverse = 0;
            while (number > 0)
            {
                int rem = number % 10;
                reverse = (reverse * 10) + rem;
                number = number / 10;
            }
            Console.WriteLine("Reversed number: {0}",reverse);
            Console.WriteLine("Last digit to first position: {0}", lastDigitToFirstPositionNumber);
            Console.WriteLine("Exchange second and thisrd digit: {0}", excahangeDigitsInNumber);

            
        }
    }
}

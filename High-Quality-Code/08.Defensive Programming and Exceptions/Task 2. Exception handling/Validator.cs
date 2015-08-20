using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Exception_handling
{
    public class Validator
    {
        public static void ValidateLessThanLength(int arrayLenght, int index, int count)
        {
            LessThanZero(index);
            LessThanZero(count);

            if (arrayLenght < index + count)
            {
                throw new IndexOutOfRangeException("Start index plus count items must be less or equal to array length!");
            }
        }

        public static void LessThanZero(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The number must be positive integer number.", "number");
            }
        }

        public static void ValidateString(string text)
        {
            if (text == null || text == string.Empty)
            {
                throw new ArgumentNullException("Text must not be null ot empty.");
            }
        }

        public static void ValidateRange(int value, int min, int max)
        {
            if (value < min || max < value)
            {
                throw new ArgumentOutOfRangeException("Value must be between " + min + " and " + max + "!");
            }
        }
    }
}

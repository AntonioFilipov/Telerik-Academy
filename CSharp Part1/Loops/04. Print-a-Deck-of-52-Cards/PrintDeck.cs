/*Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
 * The card faces should start from 2 to A.
 * Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintDeck
{
    static void Main()
    {
        string strNumber;
        for (int i = 2; i <= 14; i++)
        {
            strNumber = Convert.ToString(i);
            switch (i)
            {
                case 11: strNumber = "J"; break;
                case 12: strNumber = "Q"; break;
                case 13: strNumber = "K"; break;
                case 14: strNumber = "A"; break;
                default:
                    break;
            }

            for (int j = 0; j < 4; j++)
            {
                switch (j)
                {
                    case 0: Console.Write("{0} of shades, ", strNumber); break;
                    case 1: Console.Write("{0} of clubs, ", strNumber); break;
                    case 2: Console.Write("{0} of hearts, ", strNumber); break;
                    case 3: Console.Write("{0} of diamonds ", strNumber); break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
            

            
        }
    }
}


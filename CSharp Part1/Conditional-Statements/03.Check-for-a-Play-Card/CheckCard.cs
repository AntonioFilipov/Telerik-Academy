/*Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
 * Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.
*/
using System;

class CheckCard
{
    static void Main()
    {
        string validCardsString = "2 3 4 5 6 7 8 9 10 J Q K A";
        string[] strArray = validCardsString.Split(' ');

        Console.Write("Enter a card:");
        string input = Console.ReadLine();

        int flag = 0;
        for (int i = 0; i < strArray.Length; i++)
        {
            if (input == strArray[i])
            {
                flag = 1;
                break;
            }
        }

        Console.WriteLine(flag == 1 ? "yes":"no");
    }
}


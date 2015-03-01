/*Using loops write a program that converts an integer number to its hexadecimal representation.
 * The input is entered as long. The output should be a variable of type string.
 * Do not use the built-in .NET functionality.
*/
using System;



class DecToHex
{
    static void Main()
    {
        long number = 0;
        string hexNumber = string.Empty;
        string remainder = string.Empty;
        try 
	    {	        
		    Console.Write("Enter number(int):");
            number = long.Parse(Console.ReadLine());

            while (number != 0)
            {
                remainder += number % 16+" ";
                number /=  16;
            }

            string[] resultArray;
            resultArray = remainder.Split(' ');

            int temp=0;

            for (int i = resultArray.Length-1; i >= 0; i--)
            {
                if (int.TryParse(resultArray[i], out temp)==true && temp < 10)
                {
                    hexNumber += temp;
                }
                else
                {
                    switch (resultArray[i])
                    {
                        case "10": hexNumber += "A"; break;
                        case "11": hexNumber += "B"; break;
                        case "12": hexNumber += "C"; break;
                        case "13": hexNumber += "D"; break;
                        case "14": hexNumber += "E"; break;
                        case "15": hexNumber += "F"; break;
                        default:
                            break;
                    }
                }
               
            }
            Console.WriteLine(hexNumber);
	    }
	    catch (Exception ex)
	    {
            Console.WriteLine(ex.Message);
	    }

    }
}


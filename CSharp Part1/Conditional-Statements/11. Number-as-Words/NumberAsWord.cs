/*Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberAsWord
{
    public static string FirstDigit(int firstDigit)
    {
        string strNumber = string.Empty;
        switch (firstDigit)
        {
            case 0: break;
            case 1: strNumber = "One hundred"; break;
            case 2: strNumber = "Two hundred"; break;
            case 3: strNumber = "Three hundred"; break;
            case 4: strNumber = "Four hundred"; break;
            case 5: strNumber = "Five hundred"; break;
            case 6: strNumber = "Six hundred"; break;
            case 7: strNumber = "Seven hundred"; break;
            case 8: strNumber = "Eight hundred"; break;
            case 9: strNumber = "Nine hundred"; break;
        }
        
        return strNumber;
    }

    public static string MiddleDigit(int middleDigit, int lastDigit)
    {
        string strMidNumber = string.Empty;
        switch (middleDigit)
	    {
            case 0: break;
            case 1:
                switch (lastDigit)
                {
                    case 0: strMidNumber = "ten"; break;
                    case 1: strMidNumber = "eleven"; break;
                    case 2: strMidNumber = "twelve"; break;
                    case 3: strMidNumber = "thirteen"; break;
                    case 4: strMidNumber = "fourteen"; break;
                    case 5: strMidNumber = "fifteen"; break;
                    case 6: strMidNumber = "sixteen"; break;
                    case 7: strMidNumber = "seventeen"; break;
                    case 8: strMidNumber = "eighteen"; break;
                    case 9: strMidNumber = "nineteen"; break;
                    default:
                        break;
                }
                break;
            case 2: strMidNumber = "twenty"; break;
            case 3: strMidNumber = "thirty"; break;
            case 4: strMidNumber = "fourty"; break;
            case 5: strMidNumber = "fifty"; break;
            case 6: strMidNumber = "sixty"; break;
            case 7: strMidNumber = "seventy"; break;
            case 8: strMidNumber = "eighty"; break;
            case 9: strMidNumber = "ninety"; break;
	    }
        return strMidNumber;
    }

    public static string LastDigit(int lastDigit)
    {
        string strLastNumber = string.Empty;
        switch (lastDigit)
        {
            case 0: strLastNumber = "zero"; break;
            case 1: strLastNumber="one"; break;
            case 2: strLastNumber="two"; break;
            case 3: strLastNumber="three"; break;
            case 4: strLastNumber="four"; break;
            case 5: strLastNumber="five"; break;
            case 6: strLastNumber="six"; break;
            case 7: strLastNumber="seven"; break;
            case 8: strLastNumber="eight"; break;
            case 9: strLastNumber="nine"; break;
            default: break;
        }
        return strLastNumber;
    }


    static void Main()
    {
        int number = 0;
        Console.WriteLine("To exit, enter number out of [0..999]!");
        do
        {
            try
            {
                Console.Write("Enter number[0..999]:");
                number = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                
            


        int lastDigit = number % 10;
        int middleDigit = number / 10 % 10;
        int firstDigit = number / 100;

        string strLastNumber = string.Empty;
        string strMidNumber = string.Empty;
        string strFirstNumber = string.Empty;
        string strNumber = string.Empty;

        strFirstNumber = FirstDigit(firstDigit);
        strMidNumber = MiddleDigit(middleDigit, lastDigit);
        strLastNumber = LastDigit(lastDigit);

        if (firstDigit != 0 && middleDigit == 0 && lastDigit == 0)
        {
            strNumber = strFirstNumber;
        }
        else if (firstDigit != 0 && middleDigit == 0 && lastDigit != 0)
        {
            strNumber = strFirstNumber + " and " + strLastNumber;
        }
        else if (firstDigit != 0 && middleDigit==1)
        {
            strNumber = strFirstNumber + " and " + strMidNumber;
        }
        else if (firstDigit != 0 && middleDigit !=1 && lastDigit != 0)
        {
            strNumber = strFirstNumber + " and " + strMidNumber+"-"+strLastNumber;
        }
        else if (firstDigit != 0 && middleDigit !=1 && lastDigit == 0)
        {
             strNumber = strFirstNumber + " and " + strMidNumber;
        }
        else if (firstDigit == 0 && middleDigit == 1)
        {
            strNumber = strMidNumber;
        }
        else if (firstDigit == 0 && middleDigit != 0 && lastDigit !=0 )
        {
            strNumber = strMidNumber + "-" +strLastNumber ;
        }
        else if (firstDigit == 0 && middleDigit != 0 && lastDigit == 0)
        {
            strNumber = strMidNumber;
        }
        else if (firstDigit == 0 && middleDigit == 0)
        {
            strNumber = strLastNumber;
        }
        Console.WriteLine(strNumber);
            
        } while (number >=0 && number<=999);
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ZeroSubset
{
    static void Main()
    {
        //int number = int.Parse(Console.ReadLine());

        int[] input = { 1, 1, 1,-1, -1 };
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = i+1; j < input.Length ; j++)
            {
                if (input[i]+input[j] == 0)
                {
                    Console.WriteLine("{0}+{1}=0", input[i], input[j]);
                }
                //Console.Write(i);
                //Console.Write(j);
                //Console.WriteLine("///");
                for (int k = j+1; k <input.Length; k++)
                {
                    if (input[i] + input[j] + input[k] == 0)
                    {
                        Console.WriteLine("{0}+{1}+{2}=0", input[i], input[j], input[k]);
                    }
                    //Console.Write(i);
                    //Console.Write(j);
                    //Console.Write(k);
                    //Console.WriteLine();
                    for (int p = k + 1; p < input.Length; p++)
                    {
                        if (input[i] + input[j] + input[k] + input[p] == 0)
                        {
                            Console.WriteLine("{0}+{1}+{2}+{3}=0", input[i], input[j], input[k], input[p]);
                        }
                        //Console.Write(i);
                        //Console.Write(j);
                        //Console.Write(k);
                        //Console.Write(p);
                        //Console.Write("///");
                    }
                    //Console.WriteLine("--------");
                }
            }
            //Console.WriteLine("------------");
        }
        Console.WriteLine("!!!!!!!!!!");
    }
}


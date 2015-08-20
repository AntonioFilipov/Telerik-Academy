using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.Refactor_the_following_loop
{
    class LoopRefactores
    {
        public void PrintValue(int expectedValue)
        {
            int[] values = new int[100];

            for (int i = 0; i < values.Length; i++)
            {
                if (i % 10 == 0 && values[i] == expectedValue)
                {
                    Console.WriteLine("Value found");
                    break;
                }

                Console.WriteLine(values[i]);
            }
        }
    }
}

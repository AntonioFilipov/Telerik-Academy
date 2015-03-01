using System;

    class Allocate
    {
        static void Main()
        {
            int[] nums = new int[20];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i * 5;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(i != nums.Length - 1 ? nums[i] + ", " : nums[i] + "\n");
            }
        }
    }

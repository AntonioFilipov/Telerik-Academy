using System;

class MaxSum
{
    static int bestStart = 0, bestEnd = 0, bestSum = int.MinValue;
    static void Main()
    {
        Console.WriteLine("Enter a number for N:");
        int N = int.Parse(Console.ReadLine());

        int[] nums = new int[N];
        Console.WriteLine("Enter {0} number(s) to array:", N);
        for (int i = 0; i < N; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        FindBestSequence(nums);

        Console.WriteLine("Array's elements: {0} ", string.Join(", ", nums));
        Console.WriteLine("Maximal sum: {0}", bestSum);
        Console.Write("Sequence of maximal sum: ");
        for (int i = bestStart; i <= bestEnd; i++)
        {
            Console.Write(i != bestEnd ? nums[i] + ", " : nums[i] + "\n");
        }
    }

    private static void FindBestSequence(int[] nums)
    {
        int startIndex = 0, currentSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (currentSum <= 0)
            {
                startIndex = i;
                currentSum = 0;
            }

            currentSum += nums[i];

            if (currentSum > bestSum)
            {
                bestSum = currentSum;
                bestStart = startIndex;
                bestEnd = i;
            }
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 3, 0, 1, 4 };

        int missing = MissingNumber(nums);

        Console.WriteLine("Missing number: " + missing);
    }

    public static int MissingNumber(int[] nums)
    {
        int n = nums.Length;

        // expected sum from 0 to n
        int expectedSum = n * (n + 1) / 2;

        // actual sum
        int actualSum = 0;
        foreach (int num in nums)
        {
            actualSum += num;
        }

        return expectedSum - actualSum;
    }
}
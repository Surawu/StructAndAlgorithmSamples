using System;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Method(new int[] { 1, 1, 1, 0, 3, 3 }));
            Console.WriteLine("Hello World!");
        }

        public static int Method(int[] nums)
        {
            if (nums.Length < 2)
            {
                return nums.Length;
            }

            int i = 0;

            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] != nums[j])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }

            return i + 1;
        }
    }
}

using System;

namespace ThreeSumClosest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Method(new int[] { -3, -2, -5, 3, -4 }, -1));
            Console.WriteLine("Hello World!");
        }


        public static int Method(int[] nums, int target)
        {
            if (nums?.Length < 3)
            {
                return 0;
            }

            Array.Sort(nums);
            int ans = nums[0] + nums[1] + nums[2];

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int start = i + 1;
                int end = nums.Length - 1;

                while (start < end)
                {
                    int sum = nums[i] + nums[start] + nums[end];
                    if (Math.Abs(sum - target) < Math.Abs(ans - target))
                    {
                        ans = sum;
                    }
                    else if (sum < target)
                    {
                        start++;
                    }
                    else
                    {
                        end--;
                    }
                }
            }

            return ans;
        }
    }
}

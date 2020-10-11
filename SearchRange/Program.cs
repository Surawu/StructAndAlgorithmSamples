using System;

namespace SearchRange
{
    class Program
    {
        static void Main(string[] args)
        {
            var re = Method(new int[] { 5, 7, 7, 8, 8, 10 }, 6);

            Console.WriteLine("Hello World!");
        }

        public static int[] Method(int[] nums, int target)
        {
            Array.Sort(nums);

            var left = SearchLeftRange(nums, target);

            int right = -1;
            if (left != -1)
                right = SearchRightRange(nums, target);

            return new int[] { left, right };
        }

        private static int SearchLeftRange(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2; // 防止溢出、
                if (nums[mid] == target)
                {
                    right = mid - 1;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else // nums[mid] < target
                {
                    left = mid + 1;
                }
            }

            if (left != nums.Length && nums[left] == target)
            {
                return left;
            }

            return -1;
        }

        private static int SearchRightRange(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    left = mid + 1;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else // nums[mid] > target
                {
                    right = mid - 1;
                }
            }

            return right;
        }
    }
}

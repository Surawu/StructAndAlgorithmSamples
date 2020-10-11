using System;
using System.Collections.Generic;

namespace ThreeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = Method(new int[] {-2, 0, 1, 1, 2});
            Console.WriteLine("Hello World!");
        }

        private static IList<IList<int>> Method(int[] nums)
        {
            var ans = new List<IList<int>>();
            if (nums == null || nums.Length < 3)
            {
                return ans;
            }

            Array.Sort(nums); // O(nlogn)

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] > 0)
                {
                    break;
                }

                // 去掉重复情况
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int target = -nums[i];
                int left = i + 1, right = nums.Length - 1;
                while (left < right)  // 双指针遍历 O(n)
                {
                    if (target == nums[left] + nums[right])
                    {
                        ans.Add(new List<int>() { nums[i], nums[left], nums[right] });

                        // 双指针内缩
                        left++;
                        right--;

                        // 去重复
                        while (left < right && nums[left] == nums[left - 1])
                        {
                            left++;
                        }

                        while (left < right && nums[right] == nums[right - 1])
                        {
                            right--;
                        }
                    }
                    else if (target > nums[left] + nums[right])
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return ans;
        }
    }
}

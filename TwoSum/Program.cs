using System;
using System.Collections;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int[] Method(int[] nums, int target)
        {
            var dics = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var o = target - nums[i];
                if (dics.ContainsKey(o))
                {
                    return new int[] { dics[o], i };
                }

                if (!dics.ContainsKey(nums[i]))
                    dics.Add(nums[i], i);
            }

            return null;
        }
    }
}

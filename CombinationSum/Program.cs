using System;
using System.Collections.Generic;

namespace CombinationSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var re = CombinationSum(new int[] { 2, 3, 6, 7 }, 7);
            Console.WriteLine("Hello World!");
        }

        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<IList<int>> result = new List<IList<int>>();
            List<int> temp = new List<int>();
            Array.Sort(candidates);
            int len = candidates.Length;
            int begin = 0;
            Dfs(candidates, len, target, begin, temp, result);
            return result;
        }

        private static void Dfs(int[] candidates, int len, int target, int begin, List<int> temp, List<IList<int>> result)
        {
            if (target == 0)
            {
                result.Add(new List<int>(temp));                //通过new将temp的值复制到result中，否则每次修改时最终结果都会改变
                return;
            }
            for (int i = begin; i < len; i++)
            {
                if (target - candidates[i] < 0)
                    break;
                temp.Add(candidates[i]);
                Dfs(candidates, len, target - candidates[i], i, temp, result);
                 temp.RemoveAt(temp.Count - 1);
            }
        }

    }
}

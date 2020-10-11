using System;
using System.Collections.Generic;
using System.Text;

namespace SimplifyPath
{
    /// <summary>
    /// 简化路径
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Method("/../"));
        }

        public static string Method(string path)
        {
            var subs = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
            if (subs.Length == 0)
            {
                return "/";
            }

            var stack = new Stack<string>();
            foreach (var item in subs)
            {
                if (item.Equals(".."))
                {
                    if (stack.Count != 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    if (!item.Equals("."))
                    {
                        stack.Push(item);
                    }
                }
            }

            // 注意点
            if (stack.Count == 0)
            {
                return "/";
            }

            var sb = new StringBuilder();
            var arr = stack.ToArray();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                sb.Append($"/{arr[i]}");
            }

            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidBracket
{
    class Program
    {
        static void Main(string[] args)
        {
            var re = Method("12");
            Console.WriteLine(re);
        }

        public static bool Method(string s)
        {
            var dics = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            var chars = s.ToCharArray();
            if (chars.Length == 0)
            {
                return true;
            }

            Stack<char> stack = new Stack<char>();

            foreach (var item in chars)
            {
                if (dics.ContainsKey(item))
                {
                    stack.Push(item);
                }
                else
                {
                    // 注意：判断栈是否有元素
                    if (stack.Count == 0 || dics[stack.Pop()] != item)
                    {
                        return false;
                    }
                }
            }

            // 注意：栈中不能含有元素
            return stack.Count == 0;
        }
    }
}

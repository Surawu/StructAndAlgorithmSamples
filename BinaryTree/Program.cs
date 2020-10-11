using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int?>()
            {
                3,2,9,null,null,10,null,null,8,null,4
            };

            var node = CreateBinaryTree(list);
            LevelOrderTraversal(node);
            Console.WriteLine("Hello World!");
        }

        public static TreeNode CreateBinaryTree(List<int?> list)
        {
            if (list == null || list.Count == 0)
            {
                return null;
            }

            TreeNode node = null;
            int? data = list.First();
            list.RemoveAt(0);
            if (data != null)
            {
                node = new TreeNode(data);
                node.LeftNode = CreateBinaryTree(list);
                node.RightNode = CreateBinaryTree(list);
            }

            return node;
        }

        public static void PreOrderTraveral(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Console.WriteLine(node.Data);
            PreOrderTraveral(node.LeftNode);
            PreOrderTraveral(node.RightNode);
        }

        public static void InOrderTraveral(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            InOrderTraveral(node.LeftNode);
            Console.WriteLine(node.Data);
            InOrderTraveral(node.RightNode);
        }

        public static void PostOrderTraveral(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            PostOrderTraveral(node.LeftNode);
            PostOrderTraveral(node.RightNode);
            Console.WriteLine(node.Data);
        }

        public static void PreOrderWithStack(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode treeNode = root;
            while (treeNode != null || stack.Any())
            {
                while (treeNode != null)
                {
                    // 访问左结点，并入栈
                    Console.WriteLine(treeNode.Data);
                    stack.Push(treeNode);
                    treeNode = treeNode.LeftNode;
                }

                if (stack.Any())
                {
                    var p = stack.Pop();
                    treeNode = p.RightNode;
                }
            }
        }

        public static void InOrderWithStack(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            TreeNode node = root.LeftNode;
            while (node != null || stack.Any())
            {
                while (node != null)
                {
                    stack.Push(node);
                    node = node.LeftNode;
                }

                if (stack.Any())
                {
                    node = stack.Pop();
                    Console.WriteLine(node.Data);
                    node = node.RightNode;
                }
            }
        }

        /// <summary>
        /// 后续遍历打印顺序：左 右 根；因此访问顺序是根 右 左，而先序遍历时 根 左 右。
        /// </summary>
        /// <param name="root"></param>
        public static void PostOrderWithStack(TreeNode root)
        {
            var stack = new Stack<TreeNode>();
            var ouput = new Stack<TreeNode>(); // 存储访问顺序
            TreeNode node = root;
            while (node != null || stack.Any())
            {
                while (node != null)
                {
                    stack.Push(node);
                    ouput.Push(node);
                    node = node.RightNode;
                }

                if (stack.Any())
                {
                    node = stack.Pop();
                    node = node.LeftNode;
                }
            }

            while (ouput.Any())
            {
                Console.WriteLine(ouput.Pop().Data);
            }
        }

        public static void LevelOrderTraversal(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                var node = queue.Dequeue();
                Console.WriteLine(node.Data);

                if (node.LeftNode != null)
                {
                    queue.Enqueue(node.LeftNode);
                }

                if (node.RightNode != null)
                {
                    queue.Enqueue(node.RightNode);
                }
            }
        }
    }
}

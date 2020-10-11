using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class TreeNode
    {
        public TreeNode(int? data)
        {
            this.Data = data;
        }

        public int? Data;
        public TreeNode LeftNode;
        public TreeNode RightNode;
    }
}

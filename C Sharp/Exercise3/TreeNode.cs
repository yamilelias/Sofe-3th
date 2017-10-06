using System;

namespace Sofe.Exercise3
{
    public class TreeNode
    {
        public TreeNode Left;
        public TreeNode Right;
        public int Value;

        public TreeNode(int Value, TreeNode Left = null, TreeNode Right = null)
        {
            this.Left = Left;
            this.Right = Right;
            this.Value = Value;
        }
    }
}
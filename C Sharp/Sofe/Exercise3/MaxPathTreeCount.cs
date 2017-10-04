using System;

namespace Sofe.Exercise3
{
    public class MaxPathTreeCount
    {
        internal static int MaxPathCount(Node Root)
        {
            return 0;
        }
    }

}

class Node
{
    Node Left;
    Node Right;
    int Value;

    public Node(int Value, Node Left = null, Node Right = null)
    {
        this.Left = Left;
        this.Right = Right;
        this.Value = Value;
    }
}
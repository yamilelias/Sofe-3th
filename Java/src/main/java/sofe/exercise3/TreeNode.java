package sofe.exercise3;

public class TreeNode {
    TreeNode left;
    TreeNode right;
    int value;

    public TreeNode(int value) {
        this.value = value;
    }

    public TreeNode(int value, TreeNode left, TreeNode right) {
        this.left = left;
        this.right = right;
        this.value = value;
    }

    @Override
    public String toString() {
        return new StringBuilder().append("TreeNode{").
                append("left=").
                append(left).
                append(", right=").
                append(right).
                append(", value=").
                append(value).
                append('}').
                toString();
    }
}
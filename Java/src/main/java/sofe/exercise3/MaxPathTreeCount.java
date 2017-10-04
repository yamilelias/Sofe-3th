package sofe.exercise3;

public class MaxPathTreeCount {

    public static int maxPathCount(Node root){
        return 0;
    }

}

class Node{
    Node left;
    Node right;
    int value;

    public Node(int value){
        this.value = value;
    }

    public Node(Node left, Node right, int value){
        this.left = left;
        this.right = right;
        this.value = value;
    }
}
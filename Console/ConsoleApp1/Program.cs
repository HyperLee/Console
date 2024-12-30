// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Runtime.InteropServices;

class Program
{
    // main function
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    static void Main(string[] args)
    {
        TreeNode root = new TreeNode(3);
        root.left = new TreeNode(9);
        root.right = new TreeNode(20);
        root.right.left = new TreeNode(15);
        root.right.right = new TreeNode(7);

        Console.WriteLine("res: " + IsBalanced(root));
        Console.WriteLine("res2: " + IsBalanced2(root));
    }

    public static bool IsBalanced(TreeNode root)
    {
        if(root == null)
        {
            return true;
        }
        else
        {
            return Math.Abs(height(root.left) - height(root.right)) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
        }
    }

    public static int height(TreeNode root)
    {
        if(root == null)
        {
            return 0;
        }
        else
        {
            return Math.Max(height(root.left), height(root.right)) + 1;
        }
    }

    public static bool IsBalanced2(TreeNode root)
    {
        return height2(root) != -1;
    }

    public static int height2(TreeNode root)
    {
        if(root == null)
        {
            return 0;
        }

        int leftH = height2(root.left);
        if(leftH == -1)
        {
            return -1;
        }

        int rightH = height2(root.right);
        if(rightH == -1 || Math.Abs(leftH - rightH) > 1)
        {
            return -1;
        }

        return Math.Max(leftH, rightH) + 1;
    }
}
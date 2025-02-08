// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace ConsoleApp1
{
    internal class Program
    {
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
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(1);
            root.right = new TreeNode(4);
            root.right.left = new TreeNode(3);
            root.right.right = new TreeNode(6);

            Console.WriteLine("res: " + IsValidBST(root));
        }

        public static bool IsValidBST(TreeNode root)
        {
            return helper(root, long.MinValue, long.MaxValue);
        }

        public static bool helper(TreeNode node, long lowerbound, long upperbound)
        {
            if(node == null)
            {
                return true;
            }

            if(node.val <= lowerbound || node.val >= upperbound)
            {
                return false;
            }

            return helper(node.left, lowerbound, node.val) && helper(node.right, node.val, upperbound);
        }

    }
}


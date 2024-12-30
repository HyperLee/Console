// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class Program
{
    // main function
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    static void Main(string[] args)
    {
        TreeNode root = new TreeNode(6);
        root.left = new TreeNode(2);
        root.right = new TreeNode(8);

        root.left.left = new TreeNode(0);
        root.left.right = new TreeNode(4);

        root.left.right.left = new TreeNode(3);
        root.left.right.right = new TreeNode(5);

        root.right.left = new TreeNode(7);
        root.right.right = new TreeNode(9);

        TreeNode p = new TreeNode(2);
        TreeNode q = new TreeNode(8);

        // output root.val 
        Console.WriteLine("res: " + LowestCommonAncestor(root, p, q).val);
    }


    public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        int x = root.val;

        if(p.val < x && q.val < x)
        {
            return LowestCommonAncestor(root.left, p, q);
        }

        if(p.val > x && q.val > x)
        {
            return LowestCommonAncestor(root.right, p, q);
        }

        return root;
    }
}
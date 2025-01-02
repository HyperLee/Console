// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


namespace ConsoleApp1
{
    class Program
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
            TreeNode root = new TreeNode(3);

            root.left = new TreeNode(9);
            root.right = new TreeNode(20);

            root.right.right = new TreeNode(7);
            root.right.left = new TreeNode(15);

            Console.WriteLine("MaxDepth: " + MaxDepth(root));
            Console.WriteLine("MaxDepth2: " + MaxDepth2(root));            
        }


        public static int MaxDepth(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }

            return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }

        public static int MaxDepth2(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }

            if(root.left == null && root.right == null)
            {
                return 1;
            }

            int maxdepth = 0;

            if(root.left != null)
            {
                maxdepth = Math.Max(maxdepth, MaxDepth2(root.left));
            }

            if(root.right != null)
            {
                maxdepth = Math.Max(maxdepth, MaxDepth2(root.right));
            }

            return maxdepth + 1;
        }
    }
}


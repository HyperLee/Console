// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

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
        TreeNode root = new TreeNode(9);
        root.val = 1;
        root.left = new TreeNode(9);
        root.right = new TreeNode(20);
        root.left.val = 2;
        root.right.val = 3;
        //root.left.left = new TreeNode(9);
        root.right.left = new TreeNode(9);
        root.right.right = new TreeNode(9);
        root.right.left.val = 4;
        root.right.right.val = 5;

        var res = DiameterOfBinaryTree(root);
        Console.WriteLine("res: " + res);
    }

    public static int max = 0;

    /// <summary>
    /// ref:
    /// https://ithelp.ithome.com.tw/articles/10227129
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public static int DiameterOfBinaryTree(TreeNode root)
    {
        MaxDepth(root);

        return max;
    }


    /// <summary>
    /// 遞回
    /// 找出 左子樹 最大深度
    /// 找出 右子樹 最大深度
    /// 找出最大者 將兩者相加
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public static int MaxDepth(TreeNode root)
    {
        if(root == null)
        {
            return 0;
        }

        int left =  MaxDepth(root.left);
        int right =  MaxDepth(root.right);

        max = Math.Max(max, left + right);

        return Math.Max(left, right) + 1;
    }

}
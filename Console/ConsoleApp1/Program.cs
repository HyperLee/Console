// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// main function

using System.Security.AccessControl;

TreeNode root = new TreeNode(1);

root.left = new TreeNode(3);
root.right = new TreeNode(2);

root.left. left = new TreeNode(7);
root.left.right = new TreeNode(6);

root.right.left = new TreeNode(5);
root.right.right = new TreeNode(4);

Console.WriteLine("res: " + MinimumOperations(root));

static int MinimumOperations(TreeNode root)
{
    int res = 0;
    Queue<TreeNode> queue = new Queue<TreeNode>();
    queue.Enqueue(root);

    while(queue.Count > 0)
    {
        int size = queue.Count;
        int[] arr = new int[size];
        int[] sorted = new int[size];
        for(int i = 0; i < size; i++)
        {
            TreeNode node = queue.Dequeue();
            arr[i] = node.val;
            sorted[i] = node.val;
            if(node.left != null)
            {
                queue.Enqueue(node.left);
            }
            if(node.right != null)
            {
                queue.Enqueue(node.right);
            }
        }
        Array.Sort(sorted);
        IDictionary<int, int> targetIndices = new Dictionary<int, int>();
        for(int i = 0; i < size; i++)
        {
            targetIndices.Add(sorted[i], i);
        }

        for(int i = 0; i < size; i++)
        {
            while(arr[i] != sorted[i])
            {
                int targetIndex = targetIndices[arr[i]];
                Swap(arr, i, targetIndex);
                res++;
            }
        }
    }

    return res;
}


static void Swap(int[] arr, int index1, int index2)
{
    int temp = arr[index1];
    arr[index1] = arr[index2];
    arr[index2] = temp; 
}

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
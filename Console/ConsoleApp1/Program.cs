// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// main function
int[] input = { 2, 1, 3, 4, 5, 2 };

Console.WriteLine("res: " + FindScore(input));


/// <summary>
/// 
/// </summary>
/// <param name="nums"></param>
/// <returns></returns>
static long FindScore(int[] nums)
{
    long Score = 0;
    int n = nums.Length;
    int[][] numIndices = new int[n][];
    for(int i = 0; i < n; i++)
    {
        numIndices[i] = new int[2];
        numIndices[i][0] = nums[i];
        numIndices[i][1] = i;
    }

    Array.Sort(numIndices, (a, b) =>
    {
        if(a[0] != b[0])
        {
            return a[0] - b[0];
        }
        else
        {
            return a[1] - b[1];
        }

    });

    bool[] marked = new bool[n];
    for(int i = 0; i < n; i++)
    {
        int num = numIndices[i][0], index = numIndices[i][1];

        if(!marked[index])
        {
            Score += num;
            marked[index] = true;

            if(index > 0)
            {
                marked[index - 1] = true;
            }

            if(index < n - 1)
            {
                marked[index +1] = true;
            }
        }
    }

    return Score;
}
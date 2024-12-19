// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// main function
int[] input = { 4, 3, 2, 1, 0 };
Console.WriteLine("method1: " + MaxChunksToSorted(input));
Console.WriteLine("method2: " + MaxChunksToSorted2(input));

static int MaxChunksToSorted(int[] arr)
{
    int m = 0;
    int res = 0;

    for(int i = 0; i < arr.Length; i++)
    {
        m = Math.Max(m, arr[i]);
        if(m == i)
        {
            res++;
        }
    }

    return res;
}

static int MaxChunksToSorted2(int[] arr)
{
    int n = arr.Length;
    int res = 0;

    for(int i = 0, j = 0, min = n, max = -1; i < n; i++)
    {
        min = Math.Min(min, arr[i]);
        max = Math.Max(max, arr[i]);

        if(j == min && i == max)
        {
            res++;
            j = i + 1;
            min = 0;
            max = -1;
        }
    }

    return res;
}




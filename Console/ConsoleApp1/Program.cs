// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// main function
int[] array = {25, 64, 9, 4, 100};
int k = 4;

Console.WriteLine("res: " + PickGifts(array, k));

/// <summary>
/// 
/// </summary>
/// <param name="gifts">禮物大小</param>
/// <param name="k">跑幾輪/取幾次禮物</param>
/// <returns></returns>
static long PickGifts(int[] gifts, int k)
{
    int index = 0;
    long res = 0;

    for(int i = 0; i < k; i++)
    {
        index = Array.IndexOf(gifts, gifts.Max());
        gifts[index] = (int)Math.Sqrt(gifts[index]);
    }

    for(int i = 0; i < gifts.Length; i++)
    {
        res += gifts[i];
    }

    return res;
}
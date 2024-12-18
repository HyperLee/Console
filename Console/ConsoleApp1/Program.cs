// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// main function
int[] prices = { 8, 4, 6, 2, 3 };
var res = FinalPrices(prices);
Console.Write("res: ");
foreach(int value in res)
{
    Console.Write(value + ", ");
}

static int[] FinalPrices(int[] prices)
{
    int n = prices.Length;
    int[] res = new int[n];

    for(int i = 0; i < n; i++)
    {
        int discount = 0;
        for(int j = i + 1; j < n; j++)
        {
            if(prices[j] <= prices[i])
            {
                discount = prices[j];
                break;
            }
        }

        res[i] = prices[i] - discount;
    }

    return res;
}

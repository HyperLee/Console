// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// main function
int n = 10;
Console.WriteLine(Fibo(n));

/// <summary>
/// fibonacci function
/// </summary>
/// <param name="n"></param>
/// <returns></returns>
static long Fibo(int n)
{
    if(n <= 1)
    {
        return n;
    }

    // n = 0, result = 0
    long first = 0;
    // n = 1, result = 1
    long second = 1;
    long result = 0;

    // 要注意這邊是從2開始, 
    for(int i = 2; i <= n; i++)
    {
        result = first + second;
        first = second;
        second = result;
    }

    return result;
}
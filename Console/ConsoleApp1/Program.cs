// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// main function
int[] array = {73, 57, 49, 3, 99, 133, 20, 1};
Console.WriteLine("排序前 ");
foreach (int i in array)
{
    Console.Write(i + ", ");
}

Console.WriteLine("");

bubblesort(array);

static void bubblesort(int[] array)
{
    int len = array.Length;

    for(int i = 0; i < len - 1; i++)
    {
        for(int j = 0; j < len - i - 1; j++)
        {
            if(array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }

    Console.WriteLine("排序後 ");
    foreach(int value in array)
    {
        Console.Write(value + ", ");
    }
}
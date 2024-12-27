// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// main function
int[] input = { -1, 0, 3, 5, 9, 12 };
int target = 2;
Console.WriteLine("res: " + Search(input, target));

static int Search(int[] nums, int target)
{
    int left = 0;
    int right = nums.Length - 1;
    while(left <= right)
    {
        int middle = left + (right - left) / 2;
        if(nums[middle] > target)
        {
            right = middle - 1;
        }
        else if(nums[middle] < target)
        {
            left = middle + 1;
        }
        else
        {
            return middle;
        }
    }

    return -1;
}
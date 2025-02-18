// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int[] nums = { 1, 2, 3 };

            var result = Permute(nums);
            foreach (var item in result)
            {
                Console.WriteLine(string.Join(",", item));
            }
            Console.WriteLine();
        }

        public static IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            List<int> list = new List<int>();
            Backtrack(nums, list, result);
            return result;
        }
        
        private static void Backtrack(int[] nums, List<int> list, IList<IList<int>> result)
        {
            if(list.Count == nums.Length)
            {
                result.Add(new List<int>(list));
                return;
            }

            for(int i = 0; i < nums.Length; i++)
            {
                if(list.Contains(nums[i]))
                {
                    continue;
                }
                list.Add(nums[i]);
                Backtrack(nums, list, result);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}


// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[] array1 = new int[] { -1, 0, 1, 2, -1, -4 };
            //Console.WriteLine(ThreeSum(array1));
            var res = ThreeSum(array1);

            // result 裡面 還有一組 temp的list
            // 所以要跑兩次 才能輸出
            foreach (var temp2 in res)
            {
                Console.WriteLine("====================");
                foreach (var out2 in temp2)
                {
                    Console.WriteLine("輸出結果: " + out2);
                }
            }
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            List<int> temp;
            Array.Sort(nums);
            for(int first = 0; first < nums.Length -2; first++)
            {
                if(first > 0 && nums[first] == nums[first - 1])
                {
                    continue;
                }

                int second = first + 1;
                int third = nums.Length - 1;
                while(second < third)
                {
                    if(nums[second] == nums[second - 1] && second > first + 1)
                    {
                        second++;
                        continue;
                    }

                    int sum = nums[first] + nums[second] + nums[third];
                    if(sum == 0)
                    {
                        temp = new List<int>
                        {
                            nums[first],
                            nums[second],
                            nums[third]
                        };

                        result.Add(temp);
                        second++;
                        third--;
                    }
                    else if(sum < 0)
                    {
                        second++;
                    }
                    else
                    {
                        third--;
                    }
                }
            }

            return result;
        }


    }
}


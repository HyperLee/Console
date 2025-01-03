// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[][] input = new int[][]
            {
                 new int[]{ 1, 2 },
                 new int[]{ 3, 5 },
                 new int[]{ 6, 7 },
                 new int[]{ 8, 10 },
                 new int[]{ 12, 16 }
            };

            int[] newInterval = {4, 8 };

            var res = Insert(input, newInterval);

            // 不規則陣列輸出
            for (int i = 0; i < res.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < res[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", res[i][j], j == (res[i].Length - 1) ? "" : ", ");
                }
                System.Console.WriteLine();
            }
        }


        public static int[][] Insert(int[][] intervals, int[] newInterval)
        {
            int left = newInterval[0];
            int right = newInterval[1];
            bool merged = false;
            List<int[]> ansList = new List<int[]>();

            foreach(int[] interval in intervals)
            {
                if(interval[0] > right)
                {
                    if(!merged)
                    {
                        ansList.Add(new int[]{left, right});
                        merged = true;
                    }
                    ansList.Add(interval);
                }
                else if(interval[1] < left)
                {
                    ansList.Add(interval);
                }
                else
                {
                    left = Math.Min(left, interval[0]);
                    right = Math.Max(right, interval[1]);
                }
            }

            if(!merged)
            {
                ansList.Add(new int[]{left, right});
            }

            int[][] ans = new int[ansList.Count][];
            for(int i = 0; i < ansList.Count; i++)
            {
                ans[i] = ansList[i];
            }

            return ans;
        }
    }
}


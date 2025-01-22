// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace ConsoleApp1
{
    internal class Program
    {
 
        static void Main(string[] args)
        {   
            int[][] prerequisites = new int[][]
            {
                 new int[]{ 1, 0 }
            };

            int numCourses = 2;

            Console.WriteLine("res: " + CanFinish(numCourses, prerequisites));    
        }

        static IList<int>[] graph;
        static int[] states;

        public static bool CanFinish(int numCourses, int[][] prerequisites)
        {
            graph = new List<int>[numCourses];
            states = new int[numCourses];
            Array.Fill(states, 0);

            for(int i = 0; i < numCourses; i++)
            {
                graph[i] = new List<int>();
            }

            foreach(int[] prerequisite in prerequisites)
            {
                graph[prerequisite[1]].Add(prerequisite[0]);
            }

            for(int i = 0; i < numCourses; i++)
            {
                bool valid = DFS(i);
                if(!valid)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool DFS(int curr)
        {
            if(states[curr] == 1)
            {
                return false;
            }

            if(states[curr] == 2)
            {
                return true;
            }

            states[curr] = 1;
            IList<int> adj = graph[curr];
            foreach(int next in adj)
            {
                bool valid = DFS(next);
                if(!valid)
                {
                    return false;
                }
            }
            states[curr] = 2;
            return true;
        }

    }
}


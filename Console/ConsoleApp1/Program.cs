﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace ConsoleApp1
{
    internal class Program
    {
 
        static void Main(string[] args)
        {   
            int[] coins = new int[] {1, 2, 5};
            int amount = 11;
            Console.WriteLine("res: " + CoinChange(coins, amount));
        }

        public static int CoinChange(int[] coins, int amount)
        {
            int max = amount + 1;
            int[] dp = new int[amount + 1];
            Array.Fill(dp, max);
            dp[0] = 0;
            for(int i = 1; i <= amount; i++)
            {
                for(int j = 0; j < coins.Length; j++)
                {
                    if(coins[j] <= i)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
                    }
                }
            }

            return dp[amount] > amount ? -1 : dp[amount]; 
        }

    }
}


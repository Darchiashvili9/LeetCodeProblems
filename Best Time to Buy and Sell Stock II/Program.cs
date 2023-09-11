using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

namespace Best_Time_to_Buy_and_Sell_Stock_II
{
    internal class Program
    {
        public static int MaxProfit(int[] prices)
        {
            int sum = 0;
            int buy = 0;
            int sell = 0;
            buy = prices[0];

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < buy)
                    buy = prices[i];

                if (prices[i] > buy)
                {
                    sell = prices[i];
                    sum += sell - buy;
                    buy = prices[i];
                }
            }

            Console.WriteLine("\n\n\n\n\n\n" + sum);
            return sum;
        }

        static void Main(string[] args)
        {
            int[] nums = new int[] { 7, 6, 4, 3, 1 };
            MaxProfit(nums);


            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nHello, World!");
        }
    }
}
//Prices[i] is  the prices of a given stock on the i'th day
//maximize profit by choosing a single day  and choosing  diff day to sell the stock
using System;

public class Program
{

    public static void Main()
    {
        int[] prices = { 7, 1, 5, 3, 6, 4 };
        int result = MaxProfit(prices);
        Console.WriteLine("Max profit is: " + result);

    
        int[] prices2 = { 7, 6, 4, 3, 1 };
        Console.WriteLine("Max profit is: " + MaxProfit(prices2));
    }

    public static int MaxProfit(int[] prices)
    {
        if (prices.Length == 0) return 0;

        int minPrice = prices[0];
        int maxProfit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i]; 
            }
            else
            {
                int profit = prices[i] - minPrice;
                if (profit > maxProfit)
                {
                    maxProfit = profit; 
                }
            }
        }

        return maxProfit;
    }
}
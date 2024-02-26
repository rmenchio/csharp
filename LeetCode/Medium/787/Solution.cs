namespace LeetCode.Medium._787
{
    public class Solution
    {
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
        {
            int[] cost = new int[n];
            Array.Fill(cost, int.MaxValue);
            cost[src] = 0;

            for (int i = 0; i <= k; i++)
            {
                int[] temp = (int[])cost.Clone();
                foreach (var flight in flights)
                {
                    int from = flight[0];
                    int to = flight[1];
                    int price = flight[2];
                    if (cost[from] != int.MaxValue && temp[to] > cost[from] + price)
                    {
                        temp[to] = cost[from] + price;
                    }
                }
                cost = temp;
            }

            return cost[dst] == int.MaxValue ? -1 : cost[dst];
        }
    }
}
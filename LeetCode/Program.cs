using LeetCode.Medium._787;
class Program
{
    public static void Main(string[] args)
    {
        var teste = new Solution();

        int[][] flights = new int[][] {
            new int[] { 0, 1, 100 },
            new int[] { 1, 2, 100 },
            new int[] { 2, 0, 100 },
            new int[] { 1, 3, 600 },
            new int[] { 2, 3, 200 }
        };

        Console.WriteLine(teste.FindCheapestPrice(4, flights, 0, 3, 1));
        Console.ReadLine();
    }
}
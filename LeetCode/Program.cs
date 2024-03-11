
using LeetCode.Easy._349;
class Program
{
    public static void Main(string[] args)
    {
        var teste = new Solution();

        int[] l1 = { 1, 2, 2, 1 };
        int[] l2 = { 2, 2 };

        Console.WriteLine(teste.Intersection(l1, l2));
        Console.ReadLine();
    }
}
using LeetCode.Easy._455;
class Program
{
    public static void Main(string[] args)
    {
        var teste = new Solution();

        int[] filhos = { 1, 2 };
        int[] cookies = { 1, 2, 3 };

        Console.WriteLine(teste.FindContentChildren(filhos, cookies));
        Console.ReadLine();
    }
}
using LeetCode.Medium._1291;
class Program
{
    public static void Main(string[] args)
    {
        var teste = new Solution();

        var resultado = teste.SequentialDigits(1000, 13000).ToList();

        resultado.ForEach(Console.WriteLine);
        Console.ReadLine();
    }
}
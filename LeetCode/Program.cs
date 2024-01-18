using LeetCode.Hard._4;
class Program
{
    public static void Main(string[] args)
    {
        var teste = new Solution();
        int[] lista1 = { 1, 2 };
        int[] lista2 = { 3, 4 };

        Console.WriteLine(teste.FindMedianSortedArrays(lista1, lista2));
        Console.ReadLine();
    }
}
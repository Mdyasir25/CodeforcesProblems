using System;
 
class Program
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split("+");
        int[] inp = Array.ConvertAll(input, int.Parse);
        int[] sorted = inp.OrderBy(x => x).ToArray();
        string result = String.Join("+", sorted);
        Console.WriteLine(result);
    }
}
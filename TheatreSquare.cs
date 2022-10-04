using System;

class Program
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(" ");
        int[] inp = Array.ConvertAll(input, int.Parse);
        int n = inp[0];
        int m = inp[1];
        int a = inp[2];
        Console.WriteLine(FindMinFlagstones(n, m, a));
    }
    public static long FindMinFlagstones(int n, int m, int a)
    {
        long horizontal=1;
        while(a*horizontal<m) horizontal++;
        
        long vertical = 1;
        while(a*vertical<n) vertical++;
        
        return horizontal*vertical;
    }
}
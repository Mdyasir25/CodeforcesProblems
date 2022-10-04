using System;

class Program
{
    public static void Main()
    {
        // string[] input = Console.ReadLine().Split(" ");
        // int[] inp = Array.ConvertAll(input, int.Parse);
        string first = Console.ReadLine().ToLower();
        string second = Console.ReadLine().ToLower();
        Console.WriteLine(Compare(first, second));
    }
    public static int Compare(string first, string second)
    {
        int res = 0;
        int minLength = Math.Min(first.Length, second.Length);
        for(int i=0; i<minLength; i++)
        {
            if(first[i]>second[i])
            {
                res = 1;
                break;
            }
            if(first[i]<second[i])
            {
                res = -1;
                break;
            }
        }
        return res;
    }
}
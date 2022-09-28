using System;

class Program
{
    public static void Main()
    {
        int m = 0;
        int n = 0;
        for(int i = 1; i<=5; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            int[] arr = Array.ConvertAll(input, int.Parse);
            for(int j=1; j<=5; j++)
            {
                if (arr[j-1] == 1)
                {
                    m=i;
                    n=j;
                    break;
                }
            }
        }
        Console.WriteLine(Func(m, n));
    }
    public static int Func(int m, int n)
    {
        return Math.Abs(m-3)+Math.Abs(n-3);
    }
}

/*
Approach:
Find the index of value 1 (m,n) and calculate its absolute distance from point(3,3).
*/
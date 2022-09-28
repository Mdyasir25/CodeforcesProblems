using System;

class Program
{
    public static void Main()
    {
        string[] read = Console.ReadLine().Split(" ");
        int[] input = Array.ConvertAll(read, int.Parse);
        int m = input[0];
        int n = input[1];
        Console.WriteLine(Func(m, n));
    }
    public static int Func(int m, int n)
    {
        if(m*n == 1)
            return 0;
        else if(m%2 == 0 || n%2 == 0)
        {
            return m*n/2;
        }
        else
        {
            return (m*n-1)/2;
        }
    }
}

/*
Approach:

There are three scenarios in this problem.

1. When any of the m and n is even: Number of dominos that fits in the rectangular board will be m*n/2.
2. When both m and n are odd: Number of dominos that fits in the rectangular board will be
            (m-1)*n/2 + (n-1)/2 = (m*n-1)/2
3. Third scenario is an exception when there is only one block in the grid ie m*n==1. In this case zero
   domino will fit in.
*/
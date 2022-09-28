using System;

class Program
{
    public static void Main()
    {
        int count = 0;
        int n = Convert.ToInt32(Console.ReadLine());
        while(n>0)
        {
            // split input string to array of strings separated by a space
            string[] input = Console.ReadLine().Split(' ');
            // convert each element of input to integer
            int[] solvers = Array.ConvertAll(input, int.Parse);
            int numOfSolvers = 0;
            foreach(var solve in solvers)
            {
                if(solve == 1)
                numOfSolvers++;
            }
            if(numOfSolvers > 1)
            count++;
            n--;
        }
        Console.WriteLine(count);
    }
}
using System;

class Program
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Func(n));
    }
    public static int Func(int n)
    {
        int count = 0;
        while(n>0)
        {   
            string statement = Console.ReadLine();
            if(statement == "++X" || statement == "X++")
                count++;
            else
                count--;
            n--;
        }
        return count;
    }
}
using System;
					
public class Program
{
	public static void Main()
	{
		int w = Convert.ToInt32(Console.ReadLine());
		if(w>2 && w%2==0)
			Console.WriteLine("YES");
		else
			Console.WriteLine("NO");
	}
}
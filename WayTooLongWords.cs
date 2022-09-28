using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		List<string> words = new List<string>();
		while(n>0)
		{
			words.Add(Console.ReadLine());
			n--;
		}
		foreach(var word in words)
		{
			if(word.Length>10)
				Console.WriteLine(word[0] +""+ (word.Length-2) +""+ word[word.Length-1]);
			else
				Console.WriteLine(word);
		}
	}
}
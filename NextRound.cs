using System;

class Program
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(" ");
        int n = Convert.ToInt32(input[0]);
        int k = Convert.ToInt32(input[1]);
        input = Console.ReadLine().Split(" ");
        int[] scores = Array.ConvertAll(input, int.Parse);
        Console.WriteLine(Func(n, k, scores));
    }
    public static int Func(int n, int k, int[] scores)
    {
        int cutoff = scores[k-1];
        if(cutoff == 0)
            return FindLeftMost(scores, cutoff);
        return FindRightMost(scores, cutoff)+1;
    }
    //Find the RightMost index of a number in a given array: Apply Binary Search Algorithm
    public static int FindRightMost(int[] arr, int num)
    {
        int l = 0;
        int r = arr.Length - 1;
        while(l<=r)
        {
            int mid = (l+r)/2;
            if(arr[mid]>num)
            {
                l = mid+1;
            }
            else if(arr[mid]<num)
            {
                r = mid - 1;
            }
            else
            {
                if(mid+1>=arr.Length || arr[mid+1]!=num)
                    return mid;
                l = mid+1;
            }
        }
        return -1;
    }
    //Find the LeftMost index of a number in a given array: Apply Binary Search Algorithm
    public static int FindLeftMost(int[] arr, int num)
    {
        int l = 0;
        int r = arr.Length - 1;
        while(l<=r)
        {
            int mid = (l+r)/2;
            if(arr[mid]>num)
            {
                l = mid+1;
            }
            else if(arr[mid]<num)
            {
                r = mid - 1;
            }
            else
            {
                if(mid-1<0 || arr[mid-1]!=num)
                    return mid;
                r = mid-1;
            }
        }
        return -1;
    }
}

/*
Approach:
We first find the score of the kth participant say KScore.

If KScore is positive then all the participants above him with higher score as well as all the participants behind 
him with eqaul score are going to make it to next round. That means we need to find the index of the last 
person with score equal to KScore. The number of participants making to the next round will be LastPersonIndex-1.
        Ex: arr = [10, 8, 7, 7, 6, 6, 6, 4, 3, 2]   k = 6
        Output: 7

If KScore is 0 then all the participants with score equal to zero above him will be eliminated ie we need to find the 
RighMost index of the person having score 0. The number of participants making it to the next round will be
number of participants above him which is equal to the RightMostIndex Of 0.
        Ex: arr = [10, 8, 7, 0, 0, 0, 0, 0, 0]   k = 6
        Output: 3
*/
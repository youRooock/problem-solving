using System;

namespace MinPairSumInArray
{
  class Program
  {
    static void Main(string[] args)
    {
      var arr = new[] {3, 5, 6, 2};

      Console.Write(FindMinPairSum(arr));
    }

    static int FindMinPairSum(int[] arr)
    {
      int min1 = Int32.MaxValue;
      int min2 = Int32.MaxValue;

      foreach (var a in arr)
      {
        if (a <= min1)
        {
          min2 = min1;
          min1 = a;
        }

        if (min2 > a && a != min1)
        {
          min2 = a;
        }
      }

      return min1 + min2;
    }
  }
}
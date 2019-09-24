using System;

namespace RotateArray
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = {1, 2, 3, 4, 5, 6, 7};
      int k = 3;

      Print(arr);
      RotateRight(arr, k);
      Print(arr);
    }

    static void RotateRight(int[] arr, int count)
    {
      for (int i = 0; i < count; i++)
      {
        RotateByOneRight(arr);
      }
    }

    static void RotateByOneRight(int[] arr)
    {
      var temp = arr[arr.Length - 1];

      for (int i = arr.Length - 1; i > 0; i--)
      {
        arr[i] = arr[i - 1];
      }

      arr[0] = temp;
    }

    static void Print(int[] arr)
    {
      foreach (var a in arr)
      {
        Console.Write(a + " ");
      }

      Console.WriteLine();
    }
  }
}
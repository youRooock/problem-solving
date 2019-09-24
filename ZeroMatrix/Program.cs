using System;

namespace ZeroMatrix
{
  class Program
  {
    static void Main(string[] args)
    {
      int n = 6;
      int m = 7;
      int[,] arr = new int[n, m];

      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < m; j++)
        {
          arr[i, j] = new Random().Next(0, 10);
        }
      }

      Print(n, m, arr);

      ZeroMatrix(n, m, arr);

      Print(n, m, arr);
    }

    static void Print(int n, int m, int[,] arr)
    {
      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < m; j++)
        {
          Console.Write($"{arr[i, j]} ");
        }

        Console.WriteLine();
      }

      Console.WriteLine();
    }


    static void ZeroMatrix(int n, int m, int[,] arr)
    {
      var rows = new bool[n];
      var columns = new bool[m];

      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < m; j++)
        {
          if (arr[i, j] == 0)
          {
            rows[i] = true;
            columns[j] = true;
          }
        }
      }

      for (int i = 0; i < n; i++)
      {
        if (rows[i])
        {
          for (int j = 0; j < m; j++)
          {
            arr[i, j] = 0;
          }
        }
      }

      for (int j = 0; j < m; j++)
      {
        if (columns[j])
        {
          for (int i = 0; i < n; i++)
          {
            arr[i, j] = 0;
          }
        }
      }
    }
  }
}
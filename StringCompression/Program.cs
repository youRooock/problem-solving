using System;
using System.Collections.Generic;
using System.Text;

namespace StringCompression
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Compress("aabcccccaaa"));
      Console.WriteLine(Compress("abcd"));
      Console.WriteLine(Compress("aaaaabccddeeeeeq"));
    }

    static string Compress(string s)
    {
      var sb = new StringBuilder();
      int counter = 1;
      for (int i = 0; i < s.Length; i++)
      {
        if (i + 1 < s.Length && s[i] == s[i + 1])
        {
          counter++;
        }
        else
        {
          sb.Append(s[i]);
          sb.Append(counter);
          counter = 1;
        }
      }

      return sb.Length > s.Length ? s : sb.ToString();
    }
  }
}
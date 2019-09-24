using System;
using System.Collections.Generic;
using System.Linq;

namespace PalindromePermutation
{
  class Program
  {
    static void Main(string[] args)
    {
      string s = "Tact Coa";

      Console.WriteLine(IsPalindromePermutation(s));
    }

    static bool IsPalindromePermutation(string s)
    {
      s = s.Replace(" ", "").ToLower();
      var charsDictionary = new Dictionary<char, int>();

      foreach (var ch in s)
      {
        if (charsDictionary.ContainsKey(ch))
        {
          charsDictionary[ch]++;
        }
        else
        {
          charsDictionary[ch] = 1;
        }
      }

      int oddCharsCount = charsDictionary.Count(r => r.Value % 2 == 1);

      return oddCharsCount <= 1;
    }
  }
}
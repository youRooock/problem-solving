using System;
using System.Linq;

namespace OneAway
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(IsOneAwayEdit("pale", "ple"));
      Console.WriteLine(IsOneAwayEdit("pales", "pale"));
      Console.WriteLine(IsOneAwayEdit("pale", "bale"));
      Console.WriteLine(IsOneAwayEdit("pale", "bake"));
      Console.WriteLine(IsOneAwayEdit("pele", "pala"));
    }

    static bool IsOneAwayEdit(string s1, string s2)
    {
      int diffCharsCount = Math.Abs(s1.Length - s2.Length);
      if (diffCharsCount > 1) return false;

      var diff1 = s1.Count(ch => !s2.Contains(ch));
      var diff2 = s2.Count(ch => !s1.Contains(ch));

      if (diffCharsCount == 0)
      {
        if (diff1 > 1 || diff2 > 1) return false;
      }
      else
      {
        if (diff1 == 1 && diff2 == 0 || diff1 == 0 && diff2 == 1) return true;
      }

      return true;
    }
  }
}
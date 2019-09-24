using System;

namespace CheckPermutation
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(CheckPermutation("abcdefg", "acbfgde"));
      Console.WriteLine(CheckPermutation("abcdefg", "abbdefg"));
    }

    static bool CheckPermutation(string s1, string s2)
    {
      if (s1.Length != s2.Length) return false;

      var s1Chars = s1.ToCharArray();
      var s2Chars = s2.ToCharArray();

      Array.Sort(s1Chars);
      Array.Sort(s2Chars);

      return String.CompareOrdinal(new string(s1Chars), new string(s2Chars)) == 0;
    }
  }
}
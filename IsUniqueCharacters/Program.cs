using System;

namespace IsUniqueCharacters
{
  class Program
  {
    static void Main(string[] args)
    {
      var str1 = "abcdefg";
      var str2 = "abadcnf";

      Console.WriteLine(IsUnique(str1));
      Console.WriteLine(IsUnique(str2));
    }

    static bool IsUnique(string s)
    {
      var chars = s.ToCharArray();
      Array.Sort(chars);
      for (int i = 0, j = 1; i < chars.Length - 1; i++, j++)
      {
        if (chars[i] == chars[j]) return false;
      }

      return true;
    }
  }
}
using System;

namespace IsGivenStringPalindrome
{
  class Program
  {
    static void Main(string[] args)
    {
      string testStr1 = "abba";
      string testStr2 = "abbc";
      string testStr3 = "Was it a cat I saw";

      Console.WriteLine(IsPalindrome(testStr1));
      Console.WriteLine(IsPalindrome(testStr2));
      Console.WriteLine(IsPalindrome(testStr3));
    }

    static bool IsPalindrome(string s)
    {
      var arr = s.Replace(" ", "").ToLower().ToCharArray();

      for (int i = 0, j = arr.Length - 1; j > i; i++, j--)
      {
        if (arr[i] != arr[j]) return false;
      }

      return true;
    }
  }
}
using System;

namespace URLify
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(URLify("Hello World!"));
      Console.WriteLine(URLify("Hello    World!"));
      Console.WriteLine(URLify("Hello World!   "));
      Console.WriteLine(URLify("Hello  Wor l d! "));
      Console.WriteLine(URLify("  H e llo World !  "));

      Console.WriteLine(URLifyUsingBuiltInMethods("Hello World!"));
      Console.WriteLine(URLifyUsingBuiltInMethods("Hello    World!"));
      Console.WriteLine(URLifyUsingBuiltInMethods("Hello World!   "));
      Console.WriteLine(URLifyUsingBuiltInMethods("Hello  Wor l d! "));
      Console.WriteLine(URLifyUsingBuiltInMethods("  H e llo World !  "));
    }

    static string URLify(string url)
    {
      var chars = url.ToCharArray();
      int spaceCount = 0, x = 0, q = chars.Length - 1;

      foreach (var c in chars)
      {
        if (char.IsWhiteSpace(c))
        {
          spaceCount++;
        }
      }

      while (char.IsWhiteSpace(chars[x]))
      {
        x++;
        spaceCount--;
      }

      while (char.IsWhiteSpace(chars[q]))
      {
        q--;
        spaceCount--;
      }

      var trimmedLength = chars.Length - x - (chars.Length - 1 - q);
      var arr = new char[trimmedLength + spaceCount * 2];

      for (int i = 0, j = x; j < trimmedLength; i++, j++)
      {
        if (char.IsWhiteSpace(chars[j]))
        {
          arr[i] = '%';
          arr[++i] = '2';
          arr[++i] = '0';
        }
        else
        {
          arr[i] = chars[j];
        }
      }

      return new string(arr);
    }

    // use built in methods
    static string URLifyUsingBuiltInMethods(string url)
    {
      return url.Trim().TrimEnd().Replace(" ", "%20");
    }
  }
}
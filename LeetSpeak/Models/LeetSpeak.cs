using System.Collections.Generic;
using System;

namespace LeetSpeak.Models
{
  public static class LeetSpeaks
  // does this need to be model?
  {
    public static bool IsE(char c)
    {
      return c == 'e' || c == 'E';
    }
    public static bool IsO(char c)
    {
      return c == 'o' || c == 'O';
    }
    public static bool IsI(char c)
    {
      return c == 'I';
    }
    public static bool IsT(char c)
    {
      return c == 't' || c == 'T';
    }
    public static bool IsS(char c)
    {
      return c == 's' || c == 'S';
    }
    // public static bool StartsWord()
    // {
    //
    // }
    public static string ToLeetSpeak(string aString)
    {
      char[] inChars = aString.ToCharArray();
      for (var i=0; i < inChars.Length; i++)
      {
        if (IsE(inChars[i]))
        {
          inChars[i] = '3';
        }
        if (IsO(inChars[i]))
        {
          inChars[i] = '0';
        }
        if (IsI(inChars[i]))
        {
          inChars[i] = '1';
        }
        if (IsT(inChars[i]))
        {
          inChars[i] = '7';
        }
        if ( IsS(inChars[i]) && (i==0 || inChars[i-1] == ' ') )
        {
          inChars[i] = 'z';
        }
      }
      string newString = string.Join("", inChars);
      return newString;
    }
  }
}

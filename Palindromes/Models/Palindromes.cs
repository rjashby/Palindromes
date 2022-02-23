using System;
using System.Linq;

namespace Palindromes
{

  public class Palindrome
  {
    public bool IsPalindrome(string input)
    {
      char[] myArray = input.ToUpper().ToCharArray();
      char[] reverseArray = new char[myArray.Length];
      Array.Copy(myArray, reverseArray, myArray.Length);
      Array.Reverse(reverseArray);
      
      // if (Enumerable.SequenceEqual(myArray, reverseArray)) --- One Way
      if (myArray.SequenceEqual(reverseArray)) // --- Second Way
      {
        return true;
      }
      return false;
    }
    public bool IsPalindrome2(string input)
    {
      string test = input.ToUpper();
      for (int i = 0, j = test.Length-1; i < test.Length; i++)
      {
        if (i > j-i)
        {
          return true;
        }

        if (test[i] == test[j-i])
        {
          continue;
        }
        else
        {
          return false;
        }
      }
      return true;
    }
  }
}

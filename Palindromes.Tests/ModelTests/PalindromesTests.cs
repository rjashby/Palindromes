using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

namespace Palindromes.TestTools
{
  [TestClass]
  public class PalindromesTests
  {
    [TestMethod]
    public void IsPalindrome_CheckReverseLetters_False()
    {
      Palindrome newPalindrome = new Palindrome();
      Assert.AreEqual(false, newPalindrome.IsPalindrome("Bacon"));
    }

    [TestMethod]
    public void IsPalindrome_CheckReverseLetters_True()
    {
      Palindrome newPalindrome = new Palindrome();
      Assert.AreEqual(true, newPalindrome.IsPalindrome("Racecar"));
    }

    // isPalindrome2
    [TestMethod]
    public void IsPalindrome2_CheckReverseLetters_False()
    {
      Palindrome newPalindrome = new Palindrome();
      Assert.AreEqual(false, newPalindrome.IsPalindrome2("Bacon"));
    }

    [TestMethod]
    public void IsPalindrome2_CheckReverseLetters_True()
    {
      Palindrome newPalindrome = new Palindrome();
      Assert.AreEqual(true, newPalindrome.IsPalindrome2("Racecar"));
    }
  }
}

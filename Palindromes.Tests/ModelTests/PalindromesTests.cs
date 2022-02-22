using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

namespace Palindromes.TestTools
{
  [TestClass]
  public class PalindromesTests
  {
    [TestMethod]
    public void IsPalindrome_CheckReverseLetters_True()
    {
      Palindrome newPalindrome = new Palindrome();
      Assert.AreEqual(false, newPalindrome.IsPalindrome("Bacon"));
    }
  }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;
using LeetSpeak.Models;
using System.Collections.Generic;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class LeetSpeakTest
  {
    [TestMethod]
    public void IsE_CharIsE_True()
    {
      Assert.AreEqual(true, LeetSpeaks.IsE('e'));
    }

    [TestMethod]
    public void IsE_CharIsE_False()
    {
      Assert.AreEqual(false, LeetSpeaks.IsE('b'));
    }

    [TestMethod]
    public void IsE_CharIsO_True()
    {
      Assert.AreEqual(true, LeetSpeaks.IsO('o'));
    }

    [TestMethod]
    public void IsE_CharIsO_False()
    {
      Assert.AreEqual(false, LeetSpeaks.IsO('q'));
    }

    [TestMethod]
    public void IsE_CharIsI_True()
    {
      Assert.AreEqual(true, LeetSpeaks.IsI('I'));
    }

    [TestMethod]
    public void IsE_CharIsI_False()
    {
      Assert.AreEqual(false, LeetSpeaks.IsI('l'));
    }

    [TestMethod]
    public void IsE_CharIsIAlso_False()
    {
      Assert.AreEqual(false, LeetSpeaks.IsI('i'));
    }

    [TestMethod]
    public void IsE_CharIsT_True()
    {
      Assert.AreEqual(true, LeetSpeaks.IsT('t'));
    }

    [TestMethod]
    public void IsE_CharIsT_False()
    {
      Assert.AreEqual(false, LeetSpeaks.IsT('p'));
    }

    [TestMethod]
    public void IsE_CharIsS_True()
    {
      Assert.AreEqual(true, LeetSpeaks.IsS('s'));
    }

    [TestMethod]
    public void IsE_CharIsS_False()
    {
      Assert.AreEqual(false, LeetSpeaks.IsS('f'));
    }

    [TestMethod]
    public void ContainsLetters

  }
}

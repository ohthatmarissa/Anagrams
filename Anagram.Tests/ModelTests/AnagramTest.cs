using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest
  {

    [TestMethod]
    public void AnagramConstructor_CreatesInstanceOfAnagram_Anagram()
    {
      Anagram newAnagram = new Anagram("");
      Assert.AreEqual(typeof(Anagram), newAnagram.GetType());
    }
    [TestMethod]
    public void GetWord_GetWord_String()
    {
      string word = "Bread";
      Anagram newAnagram = new Anagram(word);
      string result = newAnagram.GetWord();
      Assert.AreEqual(word, result);
    }
    [TestMethod]
    public void SetWord_SetWord_String()
    {
      string word = "Bread";
      Anagram newAnagram = new Anagram(word);
      string updatedWord = "Beard";
      newAnagram.SetWord(updatedWord);
      string result = newAnagram.GetWord();
      Assert.AreEqual(updatedWord, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_AnagramList()
    {
      List<Anagram> newList = new List<Anagram> { };
      List<Anagram> result = Anagram.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAnagrams_AnagramList()
    {
      string word01 = "Bread";
      string word02 = "Beard";
      Anagram newAnagram1 = new Anagram(word01);
      Anagram newAnagram2 = new Anagram(word02);
      List<Anagram> newList = new List<Anagram> { newAnagram1, newAnagram2 };
      List<Anagram> result = Anagram.GetAll();
      CollectionAssert.AreEqual(newList, result);
    
    }
  }
}

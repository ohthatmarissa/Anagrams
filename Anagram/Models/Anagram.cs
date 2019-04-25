using System;
using System.Collections.Generic;

namespace Anagram
{
  public class Anagram
  {
    private string _word;
    private static List<Anagram> _instances = new List<Anagram> {};

    public Anagram(string word)
    {
      _word = word;
      _instances.Add(this);
    }
    public string GetWord()
    {
      return _word;
    }
    public void SetWord(string newWord)
    {
      _word = newWord;
    }
    public static List<Anagram> GetAll()
    {
      return _instances;
    }
  }
}

using Xunit;
using AnagramNS.Objects;
using System.Collections.Generic;
namespace AnagramNS
{
  public class AnagramTest
  {
    /* EXAMPLE
    // Have a queen object that knows what coordinants its at
    [Fact]
    public void QueenAttack_ForCoordinants_SeeCoordinants()
    {
      QueenAttack queen = new QueenAttack(8, 2);
      Assert.Equal(8, queen.GetX());
      Assert.Equal(2, queen.GetY());
    }
    /**/
    // all the letters of the original anagram are used
    [Fact]
    public void IsAnagram_ForBod_true()
    {
      // Anagram beard = ;
      // bool isAnagram = beard;
      Assert.Equal(true, new Anagram("bod").IsAnagram("bod"));
      Assert.Equal(false, new Anagram("bod").IsAnagram("tob"));
    }

    [Fact]
    public void IsAnagram_ForAnagram_true()
    {
      Assert.Equal(true,  new Anagram("bod").IsAnagram("dob"));
      Assert.Equal(true,  new Anagram("bread").IsAnagram("beard"));
      Assert.Equal(false,  new Anagram("bod").IsAnagram("boo"));
    }

    [Fact]
    public void IsAnagram_ForMainWord_LowerCase_true()
    {
      Assert.Equal(true, new Anagram("LOST").IsAnagram("slot"));
    }

    [Fact]
    public void IsListAnagram_ForList_ADictionary_true()
    {
      // TODO for chris, follow this closely!

      // instantiate anagram object named bread with main word "bread"
      Anagram bread = new Anagram("bread");
      // instantiate a list of strings called testList to include the words "beard", "berad", "debra", "googl"
      List<string> testList = new List<string>(){"beard", "berad", "debra", "googl"};
      // instantiate a dictionary of string, bool called anagramOutput and set it equal to anagrams output of IsListAnagram
      Dictionary <string, bool> anagramOutput = bread.IsListAnagram(testList);
      // instantiate a dictionary of string, bool called expectedOutput that contains the words in the list and a true or false if they are annagrams
      Dictionary <string, bool> expectedOutput = new Dictionary<string, bool>();
      expectedOutput.Add("beard", true);
      expectedOutput.Add("berad", true);
      expectedOutput.Add("debra", true);
      expectedOutput.Add("googl", false);
      // assert that both the dictionaries are equal
      Assert.Equal(expectedOutput, anagramOutput);
    }

    [Fact]
    public void IsPartialAnagram_ForBread_Read_true()
    {
      Assert.Equal(true, new Anagram("bread").IsPartialAnagram("read"));
    }
    /*
      Anagram
      object that tells you weather or not all the letters of the test word match the chosen word
      constructor takes main word

      test method takes test word
      test method returns true or false

      testList method takes a list of words
      returns a dictionary word, bool

      Tests
      small words that are just equal to eachother
      bob - bob
      bob - tom
      hey, bread is beard anagram
      case insensitivity
      eventually, hat matches path but not the other way round
    /**/
  }
}

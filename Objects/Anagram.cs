using System.Collections.Generic;
using System;
namespace AnagramNS.Objects
{
  public class Anagram
  {
    private string _mainWord;
    private Dictionary<string,bool> _outputList;

    public Anagram(string MainWord)
    {
      SetMainWord(MainWord);
    }
    public string GetMainWord()
    {
      return _mainWord;
    }
    public Dictionary<string,bool> GetOutput()
    {
      return _outputList;
    }
    public void SetMainWord(string MainWord)
    {
      _mainWord = MainWord;
    }
    public bool IsAnagram(string TestWord)
    {
      // break into array
      char[] main = _mainWord.ToLower().ToCharArray();
      char[] test =  TestWord.ToLower().ToCharArray();
      // sort
      Array.Sort(main);
      Array.Sort(test);
      // assemble back into string
      string mainOutput = string.Join("", main);
      string testOutput = string.Join("", test);
      // test equality
      return mainOutput == testOutput;
    }
    public Dictionary<string, bool> IsListAnagram(List<string> testList)
    {
      // new dictionary out
      Dictionary<string, bool> output = new Dictionary<string, bool> (){};
      // iterate over testlist, add to dictionary

      // iteration with foreach
      foreach(string test in testList) {
        output.Add(test, IsPartialAnagram(test));
      }

      // iteration with for loop
      // for(int i = 0; i < testList.Count; i++)
      // {
      //   output.Add(testList[i], IsAnagram(testList[i]));
      // }

      // iteration with while loop
      // int i = 0;
      // while(i < testList.Count) {
      //   output.Add(testList[i], IsAnagram(testList[i]));
      //   i++;
      // }
      return output;
    } // end IsListAnagram
    public bool IsPartialAnagram(string testWord)
    {
      // break into array
      char[] main = _mainWord.ToLower().ToCharArray();
      char[] test =  testWord.ToLower().ToCharArray();

      // loop through test array, looking at main array for values and when we find a match remove both values and if there are values left in test then it is not an anagram because some letters aren't found in the main array

      foreach(char letter in test) // go through the letters in test and replace them with nothing
      {
        if(Array.IndexOf(main, letter) >= 0) // if the letter is found in main word
        {
          main[Array.IndexOf(main, letter)] = ' '; // replace the character found with a space so it can't be matched again
          test[Array.IndexOf(test, letter)] = ' ';
        }
      }
      // sort to move whitespace
      Array.Sort(test);
      string testOutput = String.Join("", test); // join into a string
      return testOutput.Trim().Length <= 0; // count the string after Trim() off whitespace
    }
    public void StoreOutput(Dictionary<string,bool> anagramList)
    {
      _outputList = anagramList;
    }


  } // end class
} // end namespace

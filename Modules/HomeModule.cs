using Nancy;
using AnagramNS.Objects;
using System.Collections.Generic;
namespace AnagramNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      // home view - show two text inputs, one for the main word and one for a word list separated by spaces
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/anagram"] = _ => {
        Anagram newWords = new Anagram(Request.Form["MainWord"]);
        string NewWordList = (Request.Form["WordList"]);
        List<string> TestWords = new List<string>(NewWordList.Split(' '));
        Dictionary<string, bool> AnagramList = newWords.IsListAnagram(TestWords);
        newWords.StoreOutput(AnagramList);
        return View["view-anagram.cshtml", newWords];
      };

      // post check anagram - lists the words you input and shows weather or not they match the initial word
      // the main word

    }
  }
}

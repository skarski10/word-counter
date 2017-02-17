using Nancy;
using System.Collections.Generic;
using WordCountApp.Objects;

namespace WordCountApp
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };

            Post["/results"] = _ => {
                WordCount newWordCount = new WordCount(Request.Form["user-sentence"], Request.Form["search-word"]);
                return View["/results.cshtml", newWordCount];
            };
        }
    }
}

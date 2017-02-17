using System;
using System.Collections.Generic;
using System.IO;

namespace WordCountApp.Objects
{
    public class WordCount
    {
        private string _userString;

        public WordCount(string userSentence)
        {
            _userString = userSentence;
        }

        public string GetSentence()
        {
            return _userString;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;

namespace WordCountApp.Objects
{
    public class WordCount
    {
        private string _userString;
        private string _userWord;

        public WordCount(string userSentence, string userWord)
        {
            _userString = userSentence;
            _userWord = userWord;
        }

        public string GetUserSentence()
        {
            return _userString;
        }
        public string GetUserWord()
        {
            return _userWord;
        }
    }
}

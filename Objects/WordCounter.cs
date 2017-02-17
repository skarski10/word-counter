using System;
using System.Collections.Generic;
using System.IO;

namespace WordCountApp.Objects
{
    public class WordCount
    {
        private string _userString;
        private string _userWord;
        private string[] _userSentenceArray;

        public WordCount(string userSentence, string userWord)
        {
            _userString = userSentence;
            _userWord = userWord;
            _userSentenceArray = userSentence.Split(' ');
        }

        public string GetUserSentence()
        {
            return _userString;
        }
        public string GetUserWord()
        {
            return _userWord;
        }

        public string[] GetUserSentenceArray()
        {
            return _userSentenceArray;
        }
    }
}

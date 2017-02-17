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
        private int _wordCount;

        public WordCount(string userSentence, string userWord)
        {
            _userString = userSentence;
            _userWord = userWord;
            _userSentenceArray = userSentence.Split(' ');
        }

        public int RepeatCounter()
        {
            _wordCount = 0;
            foreach (string word in _userSentenceArray)
            {
                if(word == _userWord)
                {
                    _wordCount++;
                }
            }
            return _wordCount;
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

        public int GetWordCounter()
        {
            return _wordCount;
        }

        public bool LocateUserWord()
        {
            foreach (string word in _userSentenceArray)
            {
                if(word == _userWord)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

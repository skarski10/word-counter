using System;
using Xunit;
using System.Collections.Generic;
using WordCountApp.Objects;

namespace WordCountTestApp
{
    public class WordCountTest
    {
        // This will test to make sure the input is being returned
        [Fact]
        public void GetWordCount_ReturnsInputString_InputString()
        {
            // Arrange
            string userString = "The Atlanta Braves will win the World Series this year";
            string userWord = "win";

            // Act
            WordCount newWordCount = new WordCount(userString, userWord);

            // Assert
            Assert.Equal(userString, newWordCount.GetUserSentence());

        }
        //This will make sure both inputs are being returned
        [Fact]
        public void GetWordCount_ReturnsBothInputString_InputStringAndInputWord()
        {
            // Arrange
            string userString = "The Atlanta Braves will win the World Series this year";
            string userWord = "win";

            // Act
            WordCount newWordCount = new WordCount(userString, userWord);

            // Assert
            Assert.Equal(userString, newWordCount.GetUserSentence());
            Assert.Equal(userWord, newWordCount.GetUserWord());

        }

        //This will test to make sure we are splitting up the user string into an array of single word strings
        [Fact]
        public void GetWordCount_SplitUserInputString_UserStringSplit()
        {
            // Arrange
            string userString = "The Atlanta Braves will win the World Series this year";
            string userWord = "win";
            string[] userStringArray = { "The", "Atlanta", "Braves", "will", "win", "the", "World", "Series", "this", "year" };

            // Act
            WordCount newWordCount = new WordCount(userString, userWord);

            // Assert
            Assert.Equal(userStringArray, newWordCount.GetUserSentenceArray());
        }

        //This will test is to make sure we are splitting up the user string into an array of single word strings
        [Fact]
        public void GetWordCount_CompareSplitUserInputStringToUserWord_True()
        {
            // Arrange
            string userString = "The Atlanta Braves will win the World Series this year";
            string userWord = "win";

            // Act
            WordCount newWordCount = new WordCount(userString, userWord);

            // Assert
            Assert.Equal(true, newWordCount.LocateUserWord());
        }
        //This will test will look into the user sentence and count each time it finds the user word.
        [Fact]
        public void GetWordCount_CountUserWord_CountInt()
        {
            // Arrange
            string userString = "The Atlanta Braves will win the World Series this year";
            string userWord = "win";
            string[] userStringArray = { "The", "Atlanta", "Braves", "will", "win", "the", "World", "Series", "this", "year" };
            int wordCount = 1;

            // Act
            WordCount newWordCount = new WordCount(userString, userWord);

            // Assert
            Assert.Equal(wordCount, newWordCount.RepeatCounter());
        }
    }
}

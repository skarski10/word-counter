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
    }
}

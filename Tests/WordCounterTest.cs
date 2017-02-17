using System;
using Xunit;
using System.Collections.Generic;
using WordCountApp.Objects;

namespace WordCountTestApp
{
    public class WordCountTest
    {
        [Fact]
        public void GetWordCount_ReturnsInputString_InputString()
        {
            // Arrange
            string userString = "The Atlanta Braves will win the World Series this year";
            string userWord = "win";

            // Act
            WordCount newWordCount = new WordCount(userString);

            // Assert
            Assert.Equal(userString, newWordCount.GetSentence());

        }
    }
}

#Word Counter
**C# second week Friday code review for Epicodus, 02.17.17**
###By Kory Skarbek
##Description
The program will let input two things; search sentence and search word. The program will then tell you how many times the search word appears in the search sentence

##Specs

search string = input 1, search word = input 2

The program will take the search string and return it. This is the simplest step because the program is only taking in an input and returning it. The program doesn't have to worry about doing anything to the string that is input.
* **Input:** The Atlanta Braves will win the World Series this year
* **Output:** The Atlanta Braves will win the World Series this year

The program will take the search string and the search word and return them. This is still a simple task, but now the program has to deal with two inputs.
* **Input:** The Atlanta Braves will win the World Series this year, win
* **Output:** Input 1: The Atlanta Braves will win the World Series this year, Input 2: win

The program will split the search string into individual words array. This is the next logical step because now that we have take in both words, we are going to need to check them against each other. The easiest way to do this is to have individual string words.
* **Input:** The Atlanta Braves will win the World Series this year
* **Output:** "The" "Atlanta" "Braves" "will" "win" "the" "World" "Series" "this" "year"

The program will look through search string array we created from the search string and return the search word if it finds the search word matches one of search string arrays from the search string. This is the next best step because it will simple look to see if it finds the search word in the array of the search string.
* **Input:** The Atlanta Braves will win the World Series this year, win
* **Output:** win

The program will look though the search string array and add one to a counter each time in finds the search word within the array. This is the last step. Now that we know the program can return both search string and search word, split search string into an array of single words and compare search word to each index of the array, the last thing to do is make a count of how many times the search word appears in the search string.
* **Input:** The Atlanta Braves will win the World Series this year, win
* **Output:** Win appears 1 time in "The Atlanta Braves will win the World Series this year"

The program will
* **Input:**
* **Output:**

The program will
* **Input:**
* **Output:**

The program will
* **Input:**
* **Output:**

##Setup
Open up the terminal.
Clone this repository.
Compile program
Go to localhost:5004

##Technologies Used
C#
HTML
CSS
Bootstrap

##Legal
Copyright(c) 2017 Kory Skarbek
This software is licensed under the MIT license.

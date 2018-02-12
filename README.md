
# Leap Year

#### By Cameron Anderson & Andy Grossberg

## Description
A program to test if a given year is a leap year.

# Rules
The letter "e" should be replaced with "3".
The letter "o" should be replaced with "0".
The capital letter (not the lower case), "I", should be replaced with "1".
The letter "t" should be replaced with "7".
All instances of "s" should be replaced with "z" UNLESS it is the first letter of the word.

## Specifications
* Create LeetSpeakTest object

* Create LeetSpeak object

* choose a letter

* a. check if the letter is 'e'
- Expected Input: 'e'
- Expected Output: True
- Expected Input: 'r'
- Expected Output: False

* b. check if the letter is 'o'
- Expected Input: 'o'
- Expected Output: True
- Expected Input: 'j'
- Expected Output: False

* c. check if the letter is 'I'
- Expected Input: 'I'
- Expected Output: True
- Expected Input: 't'
- Expected Output: False
- Expected Input: 'i'
- Expected Output: False

* d. check if the letter is 't'
- Expected Input: 't'
- Expected Output: True
- Expected Input: 'n'
- Expected Output: False

* e. check if the letter is 's'
- Expected Input: 's'
- Expected Output: True
- Expected Input: 'q'
- Expected Output: False

* Display a view that is a title screen.

* display the text to the screen

* display a view with a form requesting an input string

* display the string to the screen

* convert string to char array

* repeat steps a-e for each char in the array

* a. check if the letter is 'e', if so replace with '3'
- Expected Input: 'e'
- Expected Output: 3
- Expected Input: 'r'
- Expected Output: r

* b. check if the letter is 'o', if so replace with '0'
- Expected Input: 'o'
- Expected Output: 0
- Expected Input: 'j'
- Expected Output: j

* c. check if the letter is 'I', if so replace with '1'
- Expected Input: 'I'
- Expected Output: 1
- Expected Input: 't'
- Expected Output: t
- Expected Input: 'i'
- Expected Output: i

* d. check if the letter is 't', if so replace with '7'
- Expected Input: 't'
- Expected Output: 7
- Expected Input: 'n'
- Expected Output: n

* e. check if the letter is 's', if so replace with 'z'
- Expected Input: 's'
- Expected Output: z
- Expected Input: 'q'
- Expected Output: q

* convert char array to string

* display string to screen

* refactor code as needed.

## Setup/Installation Requirements

* Clone the git repository from 'https://github.com/camander321/LeapYearTest.git'.
* run the command 'dotnet restore' to download the necessary packages.
* run the command 'dotnet run' to build and run the server on localhost.
* use your preferred web browser to navigate to localhost:5000


## Support and contact details

* contact the author at chamburg321@gmail.com

## Technologies Used

* C#
* Asp .NET Core MVC
* HTML
* CSS
* Javascript
* Bootstrap
* JQuery

### License

Copyright (c) 2018 Cameron Anderson & Andy Grossberg

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

# Lottery Game
A C# console application that simulates a weekly lottery game. Users select a day of the week, choose between an easy or hard game mode, and enter four lottery number guesses. The application generates unique lottery numbers and calculates the player's prize based on their results.

## Features
* Select a day of the week to play
* Choose between Easy and Hard game modes
* Generate four unique lottery numbers
* Enter four numbers between 1 and 50
* Validate user input
* Compare guesses against the generated lottery numbers
* Calculate winnings based on the number of correct guesses
* Different prize structures for each game mode
* Console-based user interface

## Game Modes

### Easy
In Easy mode, the four guessed numbers can match the lottery numbers in any order.
| Correct Numbers | Prize |
| --------------- | ----: |
| 0               |    £0 |
| 1               |    £1 |
| 2               |    £5 |
| 3               |   £50 |
| 4               |  £250 |

### Hard
In Hard mode, the guessed numbers must match the lottery numbers in the correct order.
| Correct Numbers |      Prize |
| --------------- | ---------: |
| 0               |         £0 |
| 1               |     £1,000 |
| 2               |    £25,000 |
| 3               |   £500,000 |
| 4               | £1,000,000 |

## How It Works
1. Select a day of the week.
2. Choose either the Easy or Hard version.
3. Enter four numbers between 1 and 50.
4. The application generates four unique lottery numbers for the selected day.
5. Your guesses are compared with the generated numbers.
6. Your winnings are calculated based on the game mode and number of correct guesses.

## Technologies
* C#
* .NET
* Visual Studio
* Object-oriented programming
* Random number generation
* Console input and output

## Skills Demonstrated
This project demonstrates my understanding of:
* C# methods and functions
* Classes and objects
* Variables and data types
* Conditional statements
* `while` loops
* Arrays
* Random number generation
* User input and validation
* Basic object-oriented programming
* Program flow and decision making

## Purpose
This project was developed to practise C# programming fundamentals, including methods, classes, conditional logic, loops, arrays, random number generation and user input validation.

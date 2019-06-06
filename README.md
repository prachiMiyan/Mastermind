# Mastermind

In this program I have made some assumptions:

Main() is in Program.cs

I have assumed that the Player's input and the number of chances he/she takes is public since it is not required to be hidden from anybody.

I have made guessNum private so that noone can see the number that is supposed to be guessed. 

When input is received from the Player, I check for wrong inputs so that edge cases can be accomodated in the project. 

I have also assumed that if there is a guessNum like 1234 and the input is 4444, the output is +, not +---. 
Each digit is an individual entity recognized by its position and value. 
The position of + and - does not hint toward the position of correct digits in the input.

It took me 30 minutes to read and design the class diagrams for this project, 1.5 hours to code the solution, and 45 minutes to test the solution. It took me a total of 2 hours 45 minutes. 

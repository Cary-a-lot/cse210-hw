# cse210-ww-student-template
My name wooow this is fun, ive messed with getting stuff with git before but im happy to learn how to make stuff with it myself- just to make sure i still have it working


This repository contains the starter code for many different projects. They are arranged folders by week. There is also an an empty sandbox project that can be used to play around with any concept you would like.

Notes for remembering specific things about C#
Common built-in variable types are:

int - Integers (whole numbers, positive and negative)
string - Strings (a sequence of characters, including letters, numbers, or symbols)
float - Floating point numbers (numbers that use decimals)
double - Double precision floating point numbers (just like a float, except it takes up twice as much memory, so it can hold larger numbers or numbers with more decimal places)
bool - Boolean variables (true or false)



Excercise 1 playspot.
example code.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}
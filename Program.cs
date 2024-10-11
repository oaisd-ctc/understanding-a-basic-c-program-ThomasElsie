using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("My name is Thomas Elsie.");

        //using variables
        int age = 18;
        string greeting = "Hello World";
        string firstname = "Thomas";
        string lastname = "Elsie";
        double money = 2.79;

        Console.WriteLine(greeting + "!" + "My name is " + firstname + " "
        + lastname + ". I am " + age + " years old. I just spent $" + money + " on an Energy Drink.");
    }
}
﻿// See https://aka.ms/new-console-template for more information


do
{

    double num1 = 0;
    double num2 = 0;
    double result = 0;

    Console.WriteLine("***************");
    Console.WriteLine("Calculator Program");
    Console.WriteLine("***************");

    Console.WriteLine("Enter number 1: ");
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter number 2: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter an option: ");
    Console.WriteLine("\t+ : Add");
    Console.WriteLine("\t- : Subtract");
    Console.WriteLine("\t* : Multiply");
    Console.WriteLine("\t/ : Divide ");
    Console.Write("Your option: ");

    switch (Console.ReadLine())
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine($"your result: {num1} + {num2} = " + result);
            break;


        case "-":
            result = num1 - num2;
            Console.WriteLine($"your result: {num1} - {num2} = " + result);
            break;

        case "*":
            result = num1 * num2;
            Console.WriteLine($"your result: {num1} * {num2} = " + result);
            break;

        case "/":
            result = num1 / num2;
            Console.WriteLine($"your result: {num1} / {num2} = " + result);
            break;

        default:
            Console.WriteLine("That was not a valid option");
            break;
    }
    Console.WriteLine("Would you like to continue? (Y,N)");
}
while (Console.ReadLine().ToUpper() == "Y");

Console.WriteLine("Bye!!!");
Console.ReadKey();
using System;

namespace TestApp
{
  class Program{
     static void Main (String[] args)
     {
                /*
       * Write an  expression that checks whether an integar is odd or even.
       */
       Console.WriteLine("------------------------------Question 1-----------------------------");
       Console.WriteLine("=====\nWrite an expression that checks whether an integar is odd or even. \n=====\n");
       Consoole.Write("Enter the number: ");
       int number = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine($"The number: {number} is odd? {number % 2 != 0}");
       Console.WriteLine($"The number: {number} is even? {number % 2 == 0}");
       Console.Writeline();

       /*
       * Write a Boolean expression that checks whether agiven integar is 
       * divisible by both 5 and 7, without a remainder
       */
       Console.WriteLine("----------Question 2----------");
       Console.WriteLine("======\nWwrite a Boolean expression that checks whether a\ngiven integar is divisible by both 5 and 7, without a remainder\n=======\n");
       Console.Write("Enter the number: ");
       int number2 = Convert.ToInt32(Console.Readline());
       Console.WriteLine($"The number: {number2} is divisible by 5 and 7? {(number2 % 5 ==0) && (number2 % 7 == 0)}");
       Console.WriteLine();

       /*
       * Write an expression that calculates the area of a trapezoid by given
       * sides a, b and height h.
       *
       Given that S = (a + b) * h / 2
       */
       Console.WriteLine("--------Question 3---------");
       Console.WriteLine("=======\nWrite an expression that calculates the area of a trapezoid by given sides a, b and height h. \n\nGiven that S = (a + b) * h / 2\n=====\n");
       Console.Write("Enter a: ");
       int a = Convert.ToInt32(Console.ReadLine());

       Console.Write("Enter b: ");
       int b = Convert.ToInt32(Console.ReadLine());

       Console.Write("Enter h: ");
       int h = Convert.ToInt32(Console.ReadLine());
       double S = (a + b) * h / 2;

       Console.WriteLine($"The area of the trapezoid of a = {a} b = {b} and h = {h} is: {s}");
       Console.WriteLine();

       /*
       *
       * The gravitational field of the Moon is approximately 17% of that on the 
       * Earth. Write a program that calculates the weight of a man on the 
       * moon by a given weight on Earth.
       */
       Console.WriteLine("--------Question 4-----------");
       Console.WriteLine("======\nThe gravitational field of the Moon is approximately 17% of that on the the Earth. \nWrite a program that calculates the weight of a man on the moon by a given weight on the Earth. \n======\n");
       Console.Write("Enter the weight: ");
       double weight = Convert.ToDouble(Console.ReadLine());
       double percentGiven = 17d / 100;
       Console.WriteLine($"The weight of the man on moon with {weight} on earth is: {weight * (percentGiven)}");
       Console.WriteLine(); 

       /*
       * Write a program that takes as input a four-digit number in format abcd
       * (e.g. 2011) and performs the following actions:
       * - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
       * - Prints on the console the number in reversed order: dcba (in our example 1102).
       * - Puts the last digits in the first position: dabc (in our example 1201).
       * - Exchanges the second and the third digits: acbd (in our example 2101).
       */
       Console.writeLine("----------Question 5---------");
       Console.WriteLine("========\nWrite a program that takes as input a four-digits number in format abcd\n(e.g. 2011) and performs the following actions:\n- Calculates the sum of the digits(in our example 2 + 0 + 1 + 1 = 4).\n- Prints on the console the number in reversed order: dcba(in our example 1102).\n- Puts the last digit in the first position: dabc(in our example 1201).\n- Exchanges the second and the third digits: acbd(in our example 2101). \n======\n");
       Console.Write("Enter a four digit number: ");
       string num = Console.ReadLine()
       int first = Convert.ToInt32(num[0].ToString());
       int second = Convert.ToInt32(num[1].ToString());
       int third = Convert.ToInt32(num[2].ToString());
       int fourth = Convert.ToInt32(num[3].ToString());

       Console.WriteLine($"Calculates the sum of the digits: {first + second + third + fourth}");
       Console.WriteLine($"Prints on the Console the number in reversed order: {fourth}{third}{second}{first}");
       Console.WriteLine($"Puts the last digits in first position: {fourth}{first}{second}{third}");
       Console.WriteLine($"Exchanges the second and the third digit: {first}{third}{second}{fourth}"); 
       
       
      
       

       
      



      }
    }
} 
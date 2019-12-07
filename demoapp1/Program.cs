using System;
using System.Collections.Generic;
using Welcome;

namespace DemoApp1
{
    class Program
    {
        static void Main( string [] args)
        {
            var screen = new LogoScreen();
            screen.ShowLogo();            
            Console.Write($"Enter a value for x: ");
            string in1 = Console.ReadLine();
            Console.Write($"Enter a value for y: ");
            string in2 = Console.ReadLine();

            double x = Convert.ToDouble(in1);
            double y = Convert.ToDouble(in2);
            double result = ( x + y ) / 2;
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.Write("Hey buddy, what's your name?: ");
            var user = Console.ReadLine();

            screen.ShowLogo();

            Console.ResetColor();
            Console.WriteLine(value: $"{user} your average is: {result:N1}");

        }

    }

}

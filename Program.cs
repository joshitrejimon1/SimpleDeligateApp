using System;

namespace SimpleDelegateApp
{
    internal class Program
    {
        delegate void DMyDelegate(string name);

        static void Main(string[] args)
        {
            DMyDelegate fptr;

            fptr = PrintHello;
            fptr += PrintHello; // You had a typo here; it should be PrintHello instead of PrintHellow
            fptr += SayGoodbye; // You had a typo here; it should be SayGoodbye instead of SayGoodBye

            fptr("Joshit"); // You should call the delegate with a parameter

            Console.ReadLine();
        }

        static void PrintHello(string studentName)
        {
            Console.WriteLine("Hello Student " + studentName);
        }

        static void SayGoodbye(string name)
        {
            Console.WriteLine("Goodbye " + name);
        }
    }
}

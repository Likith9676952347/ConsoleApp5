﻿using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            int result = cal.Sub(10, 2);
            Console.WriteLine(result);
        }
    }
}

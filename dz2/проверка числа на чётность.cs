﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace проверка_числа_на_чётность
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("введите число");
            a = double.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("число чётное");
            }
            else
            {
                Console.WriteLine("число нечётное");
            }

          
        }
    }
}

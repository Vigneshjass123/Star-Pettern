﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_pettern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 1; x <= 6; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
        
    


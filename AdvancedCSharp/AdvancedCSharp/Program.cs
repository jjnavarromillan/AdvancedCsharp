﻿using System;

namespace AdvancedCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService mathService = new MathService();
            mathService.MathPerformed += (sender,e) =>{
                Console.WriteLine("Calculatio result " + e.Result);
            };
            mathService.Multiply(57.85, 789.76);
        }
    }
    
}

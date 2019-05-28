using System;

namespace AdvancedCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService mathService = new MathService();
            mathService.MathPerformed += (result) =>{
                Console.WriteLine("Calculatio result " + result);
            };
            mathService.Multiply(57.85, 789.76);
        }
    }
    
}

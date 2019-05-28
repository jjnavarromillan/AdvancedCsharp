using System;

namespace AdvancedCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService mathService = new MathService();
            mathService.MathPerformed += OnMathPerformed;
            mathService.Multiply(57.85, 789.76);
        }
        static void OnMathPerformed(object sender, MathPerformedEventArgs e) {
            Console.WriteLine("Calculatio result " + e.Result);
        }
    }
    
}

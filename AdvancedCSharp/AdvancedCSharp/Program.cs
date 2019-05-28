using System;

namespace AdvancedCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService mathService = new MathService();
            mathService.MathPerformed += (result) => Console.WriteLine("Calculatio result " + result);
            mathService.CalculateNumbers(57.85, 789.76,(value1,value2)=> value1 * value2);
            
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.BehavioralDesignPatterns._22Strategy.ExerciseByAnotherWay
{
    // Define the discriminant strategies
    interface IDiscriminantStrategy
    {
        double CalculateDiscriminant(double a, double b, double c);
    }

    class OrdinaryDiscriminantStrategy : IDiscriminantStrategy
    {
        public double CalculateDiscriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
    }

    class RealDiscriminantStrategy : IDiscriminantStrategy
    {
        public double CalculateDiscriminant(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            return discriminant >= 0 ? discriminant : double.NaN;
        }
    }

    // Define the equation solver
    class QuadraticEquationSolver
    {
        private readonly IDiscriminantStrategy strategy;

        public QuadraticEquationSolver(IDiscriminantStrategy strategy)
        {
            this.strategy = strategy;
        }

        public (double, double) Solve(double a, double b, double c)
        {
            double discriminant = strategy.CalculateDiscriminant(a, b, c);

            if (double.IsNaN(discriminant))
            {
                return (double.NaN, double.NaN); // Return two NaN values
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return (x1, x2);
            }
        }
    }

   public class ExerciseByAnotherWay
    {
       public static void Exexuter()
        {
            double a =5;
            double b = 2;
            double c = 1;

            IDiscriminantStrategy ordinaryStrategy = new OrdinaryDiscriminantStrategy();
            IDiscriminantStrategy realStrategy = new RealDiscriminantStrategy();

            QuadraticEquationSolver solver1 = new QuadraticEquationSolver(ordinaryStrategy);
            QuadraticEquationSolver solver2 = new QuadraticEquationSolver(realStrategy);

            var result1 = solver1.Solve(a, b, c);
            var result2 = solver2.Solve(a, b, c);

            Console.WriteLine("Ordinary Discriminant Strategy: ({0}, {1})", result1.Item1, result1.Item2);
            Console.WriteLine("Real Discriminant Strategy: ({0}, {1})", result2.Item1, result2.Item2);
        }
    }
}

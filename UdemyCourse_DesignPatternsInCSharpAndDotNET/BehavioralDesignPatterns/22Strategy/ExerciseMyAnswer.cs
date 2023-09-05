using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.BehavioralDesignPatterns._22Strategy.ExerciseMyAnswer
{
  
        public interface IDiscriminantStrategy
        {
            double CalculateDiscriminant(double a, double b, double c);
        }

        public class OrdinaryDiscriminantStrategy : IDiscriminantStrategy
        {
            // todo
            public double CalculateDiscriminant(double a, double b, double c)
            {
                var discriminant = Math.Pow(b, 2) - (4 * a * c);
                return discriminant;
            }
        }

        public class RealDiscriminantStrategy : IDiscriminantStrategy
        {
            // todo (return NaN on negative discriminant!)
            public double CalculateDiscriminant(double a, double b, double c)
            {
                var discriminant = Math.Pow(b, 2) - (4 * a * c);
                if (discriminant < 0)
                    return double.NaN;
                return discriminant;
            }
        }

        public class QuadraticEquationSolver
        {
            private readonly IDiscriminantStrategy strategy;
            

            public QuadraticEquationSolver(IDiscriminantStrategy strategy)
            {
                this.strategy = strategy;
            }

            public Tuple<Complex, Complex> Solve(double a, double b, double c)
            {
                Double plusX;
                Double minusX;
                Double plusResult;
                Double minusResult;
                Double discriminant = strategy.CalculateDiscriminant(a, b, c);

                if (double.IsNaN(discriminant))
                { discriminant = 0; }

                plusX = ((b) + (Math.Sqrt(discriminant))) / (2 * a);
                minusX = ((-b) - (Math.Sqrt(discriminant))) / (2 * a);

                //plusResult = a * Math.Pow(plusX, 2) + b * plusX + c;
                //minusResult = a * Math.Pow(minusX, 2) + b * minusX + c;

                return new Tuple<Complex, Complex>(plusX, minusX);
            }
        }
}

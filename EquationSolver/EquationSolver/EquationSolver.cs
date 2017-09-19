using System;

namespace EquationsSolver
{
    public class EquationSolver
    {
        static void Main(string[] args)
        {
            var equation = Console.ReadLine();
            var equationSolver = new EquationSolver();
            var coeffitions = equationSolver.Parse(equation);
            var solutions = equationSolver.Solve(coeffitions[0], coeffitions[1], coeffitions[2]);
            Console.WriteLine($"{solutions[0]}  {solutions[1]}");
        }


        public double[] Solve(double a, double b, double c)
        {
            var solutions = new double[2];
            var discriminant = CalculateDiscriminant(a, b, c);
            solutions[0] = (-b + Math.Sqrt(discriminant)) / (2 * a);
            solutions[1] = (-b - Math.Sqrt(discriminant)) / (2 * a);
            return solutions;
        }

        public double CalculateDiscriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }

        public double[] Parse(String equation)
        {
            var coefficients = new double[3];
            equation = equation.Remove(equation.IndexOf("^2"),2);
            equation = equation.Remove(equation.IndexOf("=0"), 2);
            var strings = equation.Split('x');
            for (int i = 0; i < 3; i++)
            {
                switch (strings[i])
                {
                    case "":
                        coefficients[i] = 1.0;
                        break;
                    case "-":
                        coefficients[i] = -1.0;
                        break;
                    case "+":
                        coefficients[i] = 1.0;
                        break;
                    default:
                        coefficients[i] = Convert.ToDouble(strings[i]);
                        break;
                }
            }
            return coefficients;
        }
    }
}

using System;

namespace EquationsSolver
{
    public class EquationSolver
    {
        static void Main(string[] args)
        {
            var equation = Console.ReadLine();
            var equationSolver = new EquationSolver();
            var solutions = equationSolver.Solve(equationSolver.Parse(equation));
            Console.WriteLine($"{solutions[0]}  {solutions[1]}");
        }

        public double[] Parse(String equation)
        {
            equation = equation.Remove(equation.IndexOf("^2"), 2);
            var coefficients = new double[3];
            for (int i = 0; i < 3; i++)
            {
                coefficients[i] = FindCoefficient(ref equation);
            }
            return coefficients;
        }

        public double FindCoefficient( ref String equation)
        {
            var buffer = String.Empty;
            var coefficient = 1.00;
            var i = 0;
            while (equation[i] != 'x' && equation[i]!='=')
            {
                buffer += equation[i];
                i++;
            }
            equation = equation.Remove(0, buffer.Length +1);
            if (!(buffer == "-" || buffer == "+" || buffer == string.Empty))
            {
                coefficient = Convert.ToDouble(buffer);
            }
            else
            {
                if (buffer.Contains("-"))
                {
                    coefficient = -coefficient;
                }
            }
            return coefficient;
        }

        public double[] Solve(double[] coefficients)
        {
            var solutions = new double[2];
            var discriminant = coefficients[1] * coefficients[1] - 4 * coefficients[0] * coefficients[2];
            solutions[0] = (-coefficients[1] + Math.Sqrt(discriminant)) / (2 * coefficients[0]);
            solutions[1] = (-coefficients[1] - Math.Sqrt(discriminant)) / (2 * coefficients[0]);
            return solutions;

        }

    }
}

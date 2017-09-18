using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquationsSolver;

namespace EquationSolverTests
{
    [TestClass]
    public class EquationSolverTests
    {
        [TestMethod]
        public void ParseEquationTests()
        {
            //act
            string equation1 = "x^2+x+1=0";
            string equation2 = "-x^2-x-1=0";
            string equation3 = "10x^2-10x+20=0";
            string equation4 = "-5x^2+5x+5=0";
            EquationSolver solver = new EquationSolver();
            double[] coeffitions1 = {1.0,1.0,1.0};
            double[] coeffitions2 = { -1.0, -1.0, -1.0 };
            double[] coeffitions3 = { 10.0, -10.0, 20.0 };
            double[] coeffitions4 = { -5.0, 5.0, 5.0 };
            double[] coeffitionsFromSolver1 = new double[3];
            double[] coeffitionsFromSolver2 = new double[3];
            double[] coeffitionsFromSolver3 = new double[3];
            double[] coeffitionsFromSolver4 = new double[3];

            //arrange
            coeffitionsFromSolver1 = solver.Parse(equation1);
            coeffitionsFromSolver2 = solver.Parse(equation2);
            coeffitionsFromSolver3 = solver.Parse(equation3);
            coeffitionsFromSolver4 = solver.Parse(equation4);

            //Assert
            Assert.IsTrue(coeffitions1[0] == coeffitionsFromSolver1[0] &&
                          coeffitions1[1] == coeffitionsFromSolver1[1] &&
                          coeffitions1[2] == coeffitionsFromSolver1[2]);

            Assert.IsTrue(coeffitions2[0] == coeffitionsFromSolver2[0] &&
                          coeffitions2[1] == coeffitionsFromSolver2[1] &&
                          coeffitions2[2] == coeffitionsFromSolver2[2]);

            Assert.IsTrue(coeffitions3[0] == coeffitionsFromSolver3[0] &&
                          coeffitions3[1] == coeffitionsFromSolver3[1] &&
                          coeffitions3[2] == coeffitionsFromSolver3[2]);

            Assert.IsTrue(coeffitions4[0] == coeffitionsFromSolver4[0] &&
                          coeffitions4[1] == coeffitionsFromSolver4[1] &&
                          coeffitions4[2] == coeffitionsFromSolver4[2]);
        }

        [TestMethod]
        public void FindCoeffitionsTests()
        {
            //act
            EquationSolver solver = new EquationSolver();
            string equation1 = "x^2+x+1=0";
            equation1 = equation1.Remove(equation1.IndexOf("^2"), 2);
            double[] coeffitions = new double[3];
            //arrange
            for (int i = 0; i < 3; i++)
            {
                coeffitions[i] = solver.FindCoefficient( ref equation1);
            }
            //assert
            Assert.IsTrue(coeffitions[0] == 1.0 &&
                          coeffitions[1] == 1.0 &&
                          coeffitions[2] == 1.0);
        }

        [TestMethod]
        public void SolveEquation()
        {
            EquationSolver equationSolver = new EquationSolver();
            string equation1 = "x^2-4x+4=0";
            string equation2 = "x^2-6x+8=0";
            double[] solution1 = {2.0, 2.0};
            double[] solution2 = {4.0, 2.0};
            double[] fromSolver1 = equationSolver.Solve(equationSolver.Parse(equation1));
            double[] fromSolver2 = equationSolver.Solve(equationSolver.Parse(equation2));

            Assert.IsTrue(fromSolver1[0] == solution1[0] &&
                          fromSolver1[1] == solution1[1]);

            Assert.IsTrue(fromSolver2[0] == solution2[0] &&
                          fromSolver2[1] == solution2[1]);


        }
    }
}

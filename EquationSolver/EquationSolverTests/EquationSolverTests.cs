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
            var equation1 = "x^2+x+1=0";
            var equation2 = "-x^2-x-1=0";
            var equation3 = "10x^2-10x+20=0";
            var equation4 = "-5x^2+5x+5=0";
            var solver = new EquationSolver();
            var coeffitions1 = new[] {1.0,1.0,1.0};
            var coeffitions2 = new[] { -1.0, -1.0, -1.0 };
            var coeffitions3 = new[] { 10.0, -10.0, 20.0 };
            var coeffitions4 = new[] { -5.0, 5.0, 5.0 };
            var coeffitionsFromSolver1 = new double[3];
            var coeffitionsFromSolver2 = new double[3];
            var coeffitionsFromSolver3 = new double[3];
            var coeffitionsFromSolver4 = new double[3];

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
            var solver = new EquationSolver();
            var equation1 = "x^2+x+1=0";
            equation1 = equation1.Remove(equation1.IndexOf("^2"), 2);
            var coeffitions = new double[3];
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
            var equationSolver = new EquationSolver();
            var equation1 = "x^2-4x+4=0";
            var equation2 = "x^2-6x+8=0";
            var solution1 = new[] {2.0, 2.0};
            var solution2 = new[] {4.0, 2.0};
            var fromSolver1 = equationSolver.Solve(equationSolver.Parse(equation1));
            var fromSolver2 = equationSolver.Solve(equationSolver.Parse(equation2));

            Assert.IsTrue(fromSolver1[0] == solution1[0] &&
                          fromSolver1[1] == solution1[1]);

            Assert.IsTrue(fromSolver2[0] == solution2[0] &&
                          fromSolver2[1] == solution2[1]);


        }
    }
}

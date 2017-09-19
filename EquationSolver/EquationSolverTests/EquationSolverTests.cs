using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquationsSolver;

namespace EquationSolverTests
{
    [TestClass]
    public class EquationSolverTests
    {
        [TestMethod]
        public void ParseCoeffitionsWhenFirstCoefficitionIsLessThanZero()
        {
            //act
            var equation = "-5x^2+5x+5=0";
            var solver = new EquationSolver();
            var coeffitions = new[] { -5.0, 5.0, 5.0 };
            var coeffitionsFromSolver = new double[3];

            //arrange
            coeffitionsFromSolver = solver.Parse(equation);

            //Assert
            Assert.IsTrue(coeffitions[0] == coeffitionsFromSolver[0] &&
                          coeffitions[1] == coeffitionsFromSolver[1] &&
                          coeffitions[2] == coeffitionsFromSolver[2]);
        }

        [TestMethod]
        public void ParseWhenCoeffitionsEqualsOne()
        {
            var equation = "-x^2-x-1=0";
            var solver = new EquationSolver();
            var coeffitions = new[] { -1.0, -1.0, -1.0 };
            var coeffitionsFromSolver = solver.Parse(equation);
            Assert.IsTrue(coeffitions[0] == coeffitionsFromSolver[0] &&
                          coeffitions[1] == coeffitionsFromSolver[1] &&
                          coeffitions[2] == coeffitionsFromSolver[2]);

        }

        [TestMethod]
        public void ParseWhenCoeffitionsEqualsMinusOne()
        {
            var equation = "x^2+x+1=0";
            var solver = new EquationSolver();
            var coeffitions = new[] { 1.0, 1.0, 1.0 };
            var coeffitionsFromSolver = solver.Parse(equation);
            Assert.IsTrue(coeffitions[0] == coeffitionsFromSolver[0] &&
                          coeffitions[1] == coeffitionsFromSolver[1] &&
                          coeffitions[2] == coeffitionsFromSolver[2]);

        }

        [TestMethod]
        public void ParseCoeffitionsWhenSecondCoeffitionIsLessThanZero()
        {
            var equation = "10x^2-10x+20=0";
            var solver = new EquationSolver();
            var coeffitions = new[] { 10.0, -10.0, 20.0 };
            var coeffitionsFromSolver = solver.Parse(equation);
            Assert.IsTrue(coeffitions[0] == coeffitionsFromSolver[0] &&
                          coeffitions[1] == coeffitionsFromSolver[1] &&
                          coeffitions[2] == coeffitionsFromSolver[2]);
        }

        [TestMethod]
        public void FindCoeffitionsInEquationWhenAllCoeffitionsAreEqualsOne()
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
        public void FindCoeffitionsInEquationWhenAllCoeffitionsAreEqualsMinusOne()
        {
            //act
            var solver = new EquationSolver();
            var equation1 = "-x^2-x-1=0";
            equation1 = equation1.Remove(equation1.IndexOf("^2"), 2);
            var coeffitions = new double[3];
            //arrange
            for (int i = 0; i < 3; i++)
            {
                coeffitions[i] = solver.FindCoefficient(ref equation1);
            }
            //assert
            Assert.IsTrue(coeffitions[0] == -1.0 &&
                          coeffitions[1] == -1.0 &&
                          coeffitions[2] == -1.0);
        }

        [TestMethod]
        public void CalculateDiscriminant()
        {
            //act
            var equationSolver = new EquationSolver();
            var a = 4.0;
            var b = 8.0;
            var c = 2.0;
            //arrange
            var discriminant = equationSolver.CalculateDiscriminant(a, b, c);
            //Assert
            Assert.AreEqual(discriminant,32.0);
        }

        [TestMethod]
        public void SolveEquationWhenSolutionsAreSame()
        {
            // act
            var equationSolver = new EquationSolver();
            var equation = "x^2-4x+4=0";
            var coefficitions = equationSolver.Parse(equation);
            var solutions = new[] { 2.0, 2.0 };

            // arrange
            var solutionsFromSolver = equationSolver.Solve(coefficitions[0],coefficitions[1],coefficitions[2]);

            //assert
            Assert.IsTrue(solutionsFromSolver[0] == solutions[0] &&
                          solutionsFromSolver[1] == solutions[1]);
        }

        [TestMethod]
        public void SolveEquationWhenSolutionsAreNotSame()
        {
            //act
            var equationSolver = new EquationSolver();
            var equation = "x^2-6x+8=0";
            var coefficitions = equationSolver.Parse(equation);
            var solutions = new[] { 4.0, 2.0 };

            //arrange
            var solutionsFromSolver = equationSolver.Solve(coefficitions[0], coefficitions[1], coefficitions[2]);

            //assert
            Assert.IsTrue(solutionsFromSolver[0] == solutions[0] &&
                          solutionsFromSolver[1] == solutions[1]);


        }
    }
}

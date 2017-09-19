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
            //arrange
            var equation = "-5x^2+5x+5=0";
            var solver = new EquationSolver();
            var coeffitions = new[] { -5.0, 5.0, 5.0 };
            var coeffitionsFromSolver = new double[3];

            //act
            coeffitionsFromSolver = solver.Parse(equation);

            //Assert
            Assert.IsTrue(coeffitions[0] == coeffitionsFromSolver[0] &&
                          coeffitions[1] == coeffitionsFromSolver[1] &&
                          coeffitions[2] == coeffitionsFromSolver[2]);
        }

        [TestMethod]
        public void ParseWhenCoeffitionsEqualsOne()
        {
            //arrange
            var equation = "-x^2-x-1=0";
            var solver = new EquationSolver();
            var coeffitions = new[] { -1.0, -1.0, -1.0 };
            //act
            var coeffitionsFromSolver = solver.Parse(equation);
            //assert
            Assert.IsTrue(coeffitions[0] == coeffitionsFromSolver[0] &&
                          coeffitions[1] == coeffitionsFromSolver[1] &&
                          coeffitions[2] == coeffitionsFromSolver[2]);

        }

        [TestMethod]
        public void ParseWhenCoeffitionsEqualsMinusOne()
        {
            //arrange
            var equation = "x^2+x+1=0";
            var solver = new EquationSolver();
            var coeffitions = new[] { 1.0, 1.0, 1.0 };
            //act
            var coeffitionsFromSolver = solver.Parse(equation);
            //assert
            Assert.IsTrue(coeffitions[0] == coeffitionsFromSolver[0] &&
                          coeffitions[1] == coeffitionsFromSolver[1] &&
                          coeffitions[2] == coeffitionsFromSolver[2]);

        }

        [TestMethod]
        public void ParseCoeffitionsWhenSecondCoeffitionIsLessThanZero()
        {
            //arrange
            var equation = "10x^2-10x+20=0";
            var solver = new EquationSolver();
            var coeffitions = new[] { 10.0, -10.0, 20.0 };
            //act
            var coeffitionsFromSolver = solver.Parse(equation);
            //assert
            Assert.IsTrue(coeffitions[0] == coeffitionsFromSolver[0] &&
                          coeffitions[1] == coeffitionsFromSolver[1] &&
                          coeffitions[2] == coeffitionsFromSolver[2]);
        }
        
        [TestMethod]
        public void CalculateDiscriminant()
        {
            //arrange
            var equationSolver = new EquationSolver();
            var a = 4.0;
            var b = 8.0;
            var c = 2.0;
            //act
            var discriminant = equationSolver.CalculateDiscriminant(a, b, c);
            //Assert
            Assert.AreEqual(discriminant,32.0);
        }

        [TestMethod]
        public void SolveEquationWhenSolutionsAreSame()
        {
            // arrange
            var equationSolver = new EquationSolver();
            var equation = "x^2-4x+4=0";
            var coefficitions = equationSolver.Parse(equation);
            var solutions = new[] { 2.0, 2.0 };

            // act
            var solutionsFromSolver = equationSolver.Solve(coefficitions[0],coefficitions[1],coefficitions[2]);

            //assert
            Assert.IsTrue(solutionsFromSolver[0] == solutions[0] &&
                          solutionsFromSolver[1] == solutions[1]);
        }

        [TestMethod]
        public void SolveEquationWhenSolutionsAreNotSame()
        {
            //arrange
            var equationSolver = new EquationSolver();
            var equation = "x^2-6x+8=0";
            var coefficitions = equationSolver.Parse(equation);
            var solutions = new[] { 4.0, 2.0 };

            //act
            var solutionsFromSolver = equationSolver.Solve(coefficitions[0], coefficitions[1], coefficitions[2]);

            //assert
            Assert.IsTrue(solutionsFromSolver[0] == solutions[0] &&
                          solutionsFromSolver[1] == solutions[1]);


        }
    }
}

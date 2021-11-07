using Hepsiburada.Assestment.Solve.Helper;
using Hepsiburada.Assestment.Solve.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hepsiburada.Assestment.Test
{
    [TestClass]
    public class AssestmentTest
    {
        [TestMethod]
        public void Test_12N_LMLMLMLMM()
        {
            Position position = new Position()
            {
                X = 1,
                Y = 2,
                Direction = Directions.N
            };

            var moves = "LMLMLMLMM";

            position.StartMoving(moves);

            var actualOutput = $"{position.X} {position.Y} {position.Direction}";
            var expectedOutput = "1 3 N";

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test_33E_MMRMMRMRRM()
        {
            Position position = new Position()
            {
                X = 3,
                Y = 3,
                Direction = Directions.E
            };

            var moves = "MMRMMRMRRM";

            position.StartMoving(moves);

            var actualOutput = $"{position.X} {position.Y} {position.Direction}";
            var expectedOutput = "5 1 E";

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}

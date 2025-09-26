namespace SolverTests
{
    public class SolverTests
    {
        [Fact]
        public void Test_Example1_ArrayEqualization()
        {
            int[] input = { 1, 2, 9, 7, 6, 6, 6 };
            int k = 2;
            int[] expected = { 1, 2, 6, 6, 6, 6, 6 };
            int[] result = Solver.EqualizeTeamSizeArray(input, k);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Example2_ArrayEqualization()
        {
            int[] input = { 2, 5, 3, 3, 6, 7, 8 };
            int k = 2;
            int[] expected = { 2, 3, 3, 5, 6, 6, 6 };
            int[] result = Solver.EqualizeTeamSizeArray(input, k);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Example3_ArrayEqualization()
        {
            int[] input = { 20, 20, 20, 4, 4, 1 };
            int k = 3;
            int[] expected = { 1, 4, 4, 4, 4, 4 };
            int[] result = Solver.EqualizeTeamSizeArray(input, k);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestExample()
        {
            int[] teamSize = { 1, 2, 2, 3, 4 };
            int k = 2;
            Assert.Equal(4, Solver.EqualizeTeamSize(teamSize, k));
        }

        [Fact]
        public void TestInvalidInput_Null()
        {
            Assert.Equal(0, Solver.EqualizeTeamSize(null, 2));
        }

        [Fact]
        public void TestInvalidInput_Empty()
        {
            Assert.Equal(0, Solver.EqualizeTeamSize(new int[0], 2));
        }

        [Fact]
        public void TestInvalidInput_NegativeK()
        {
            Assert.Equal(0, Solver.EqualizeTeamSize(new int[] { 1, 2, 3 }, -1));
        }

        [Fact]
        public void TestInvalidInput_NonPositive()
        {
            Assert.Equal(0, Solver.EqualizeTeamSize(new int[] { 1, 0, 3 }, 1));
        }

        [Fact]
        public void TestAllSameSize()
        {
            int[] teamSize = { 2, 2, 2, 2 };
            int k = 1;
            Assert.Equal(4, Solver.EqualizeTeamSize(teamSize, k));
        }

        [Fact]
        public void TestReduceToSmallest()
        {
            int[] teamSize = { 1, 2, 3, 4 };
            int k = 3;
            Assert.Equal(4, Solver.EqualizeTeamSize(teamSize, k));
        }
    }
}


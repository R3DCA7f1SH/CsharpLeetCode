using CsharpLeetCode.Main.Medium;

namespace CsharpLeetCode.Tests.Medium
{
    public class TripleSumTests
    {
        private readonly TripleSum tripleSum = new();

        [Fact]
        public void FirstCase()
        {
            var nums = new int[] { -1, 0, 1, 2, -1, -4 };
            var exceptedNums = new List<List<int>>()
            {
                new List<int> { -1, -1, 2 },
                new List<int> { -1,0,1 },
            };
            var resultNums = tripleSum.ThreeSum(nums);
            Assert.Equal(exceptedNums.Count, resultNums.Count);
            //Assert.Equal(exceptedNums, resultNums);
        }

        [Fact]
        public void SecondCase()
        {
            var nums = new int[] { 0, 1, 1 };
            var exceptedNums = new List<List<int>>();
            var resultNums = tripleSum.ThreeSum(nums);
            Assert.Equal(exceptedNums.Count, resultNums.Count);
            //Assert.Equal(exceptedNums, resultNums);
        }

        [Fact]
        public void ThirdCase()
        {
            var nums = new int[] { 0, 0, 0 };
            var exceptedNums = new List<List<int>>()
            {
                new List<int>{ 0, 0, 0 }
            };
            var resultNums = tripleSum.ThreeSum(nums);
            Assert.Equal(exceptedNums.Count, resultNums.Count);
            //Assert.Equal(exceptedNums, resultNums);
        }


        [Fact]
        public void FourCase()
        {
            var nums = new int[] { -1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4 };
            var exceptedNums = new List<List<int>>()
            {
                new List<int>{ -4, 0, 4 },
                new List<int>{ -4, 1, 3 },
                new List<int>{ -3, -1, 4 },
                new List<int>{ -3, 0, 3 },
                new List<int>{ -3, 1, 2 },
                new List<int>{ -2, -1, 3 },
                new List<int>{ -2, 0, 2 },
                new List<int>{ -1, -1, 2 },
                new List<int>{ -1, 0, 1 },
            };
            var resultNums = tripleSum.ThreeSum(nums);
            Assert.Equal(exceptedNums.Count, resultNums.Count);
            //Assert.Equal(exceptedNums, resultNums);
        }

        [Fact]
        public void FiveCase()
        {
            var nums = new int[] { -5, 0, -2, 3, -2, 1, 1, 3, 0, -5, 3, 3, 0, -1 };
            var exceptedNums = new List<List<int>>()
            {
                new List<int>{ -2, -1, 3},
                new List<int>{ -2, 1, 1 },
                new List<int>{ -1, 0, 1 },
                new List<int>{ 0, 0, 0 }
            };
            var resultNums = tripleSum.ThreeSum(nums);
            Assert.Equal(exceptedNums.Count, resultNums.Count);
            //Assert.Equal(exceptedNums, resultNums);
        }

        [Fact]
        public void SixCase()
        {
            var nums = new int[] { -4, -2, 1, -5, -4, -4, 4, -2, 0, 4, 0, -2, 3, 1, -5, 0 };
            var exceptedNums = new List<List<int>>()
            {
                new List<int>{ -5, 1, 4},
                new List<int>{ -4, 0, 4 },
                new List<int>{ -4, 1, 3 },
                new List<int>{ -2, -2, 4 },
                new List<int>{ -2, 1, 1 },
                new List<int>{ 0, 0, 0 },
            };
            var resultNums = tripleSum.ThreeSum(nums);
            Assert.Equal(exceptedNums.Count, resultNums.Count);
            //Assert.Equal(exceptedNums, resultNums);
        }
    }


    //[[-4,0,4],[-4,1,3],[-3,-1,4],[-3,0,3],[-3,1,2],[-2,-1,3],[-2,0,2],[-1,-1,2],[-1,0,1]]...
}

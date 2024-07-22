namespace CsharpLeetCode.Tests.Medium
{
    using CsharpLeetCode.Main.Medium;

    public class PartitionIntoMinNumOfDeciBinaryNumTests
    {
        private readonly PartitionIntoMinNumOfDeciBinaryNum _partitionIntoMinNumOfDeciBinaryNum=new();
        
        [Fact]
        public void FirstCase()
        {
            Assert.Equal(3, _partitionIntoMinNumOfDeciBinaryNum.MinPartitions("32"));
        }

        [Fact]
        public void SecondCase()
        {
            Assert.Equal(8, _partitionIntoMinNumOfDeciBinaryNum.MinPartitions("82734"));
        }

        [Fact]
        public void ThirdCase()
        {
            Assert.Equal(9, _partitionIntoMinNumOfDeciBinaryNum.MinPartitions("27346209830709182346"));
        }

        [Fact]
        public void FourCase()
        {
            Assert.Equal(1, _partitionIntoMinNumOfDeciBinaryNum.MinPartitions("1"));
        }

        [Fact]
        public void MyCase()
        {
            Assert.Equal(9, _partitionIntoMinNumOfDeciBinaryNum.MinPartitions("35670234123901112341241523523521299988221241"));
        }
    }
}
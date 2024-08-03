using CsharpLeetCode.Main.Medium;

namespace CsharpLeetCode.Tests.Medium;

public class ContainerWithMostWaterTests
{
    private readonly ContainerWithMostWater _containerWithMostWater = new();

    [Fact]
    public void CaseN1()
    {
        var heights = new [] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        var expected = 49;
        var result = _containerWithMostWater.MaxArea(heights);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CaseN2()
    {
        var heights = new[] { 1, 1 };
        var expected = 1;
        var result = _containerWithMostWater.MaxArea(heights);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CaseN3()
    {
        var heights = new[] { 1, 2, 4, 3 };
        var expected = 4;
        var result = _containerWithMostWater.MaxArea(heights);
        Assert.Equal(expected, result);
    }
}

using CsharpLeetCode.Main.Medium;

namespace CsharpLeetCode.Tests.Medium;
public class DivideTwoIntegersTests
{
    private readonly DivideTwoIntegers _divideTwoIntegers = new();
    
    [Fact]
    public void FirstCase()
    {
        var result = _divideTwoIntegers.Divide(10, 3);
        var expected = 3;
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SecondCase()
    {
        var result = _divideTwoIntegers.Divide(7, -3);
        var expected = -2;
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ThirdCase()
    {
        var result = _divideTwoIntegers.Divide(1, 1);
        var expected = 1;
        Assert.Equal(expected, result);
    }


    [Fact]
    public void FourCase()
    {
        var result = _divideTwoIntegers.Divide(-2147483648, -1);
        var expected = 2147483647;
        Assert.Equal(expected, result);
    }

    [Fact]
    public void FiveCase()
    {
        var result = _divideTwoIntegers.Divide(-1, 1);
        var expected = -1;
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SixCase()
    {
        var result = _divideTwoIntegers.Divide(-2147483648, 2);
        var expected = -2147483648/2;
        Assert.Equal(expected, result);
    }
}


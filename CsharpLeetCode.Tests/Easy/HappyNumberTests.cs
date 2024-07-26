using CsharpLeetCode.Main.Easy;

namespace CsharpLeetCode.Tests.Easy;

public class HappyNumberTests
{
    private readonly HappyNumberSolution _isHappy = new();
    
    [Fact]
    public void CaseN1()
    {
        var parameter = 19;
        var expected = true;
        var result = _isHappy.IsHappy(parameter);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CaseN2()
    {
        var parameter = 2;
        var expected = false;
        var result = _isHappy.IsHappy(parameter);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CaseN3()
    {
        var parameter = 11;
        var expected = false;
        var result = _isHappy.IsHappy(parameter);
        Assert.Equal(expected, result);
    }
}

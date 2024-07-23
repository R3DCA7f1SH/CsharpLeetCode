using CsharpLeetCode.Main.Easy;

namespace CsharpLeetCode.Tests.Easy;
public class SortArrayByIncreasingFrequencyTests
{
    private readonly SortArrayByIncreasingFrequency _sortArrayByIncreasingFrequency = new();
    [Fact]
    public void CaseN1()
    {
        var nums = new int[] { 1, 1, 2, 2, 2, 3 };
        var expected = new int[] { 3, 1, 1, 2, 2, 2 };
        var result = _sortArrayByIncreasingFrequency.FrequencySort(nums);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CaseN2()
    {
        var nums = new int[] { 2, 3, 1, 3, 2 };
        var expected = new int[] { 1, 3, 3, 2, 2 };
        var result = _sortArrayByIncreasingFrequency.FrequencySort(nums);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CaseN3()
    {
        var nums = new int[] { -1, 1, -6, 4, 5, -6, 1, 4, 1 };
        var expected = new int[] { 5, -1, 4, 4, -6, -6, 1, 1, 1 };
        var result = _sortArrayByIncreasingFrequency.FrequencySort(nums);
        Assert.Equal(expected, result);
    }

}


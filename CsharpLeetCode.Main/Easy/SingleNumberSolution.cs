namespace CsharpLeetCode.Main.Easy;
public class SingleNumberSolution
{
    public int SingleNumber(int[] nums)
    {
        var result = nums[0];
        for (int i = 1; i < nums.Length; i++) result ^= nums[i];
        return result;
    }
}

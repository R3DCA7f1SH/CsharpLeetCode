namespace CsharpLeetCode.Main.Medium;
public class SortArrayNlogn
{
    public int[] SortArray(int[] nums)
    {
        if (nums.Length == 1) return nums;
        var middle = nums.Length / 2;
        var left = new int[middle];
        for (int i = 0; i < middle; i++) left[i] = nums[i];
        var right = new int[nums.Length - middle];
        for (int i = 0; i < nums.Length - middle; i++) right[i] = nums[i + middle];
        left = SortArray(left);
        right = SortArray(right);
        int leftptr = 0;
        int rightptr = 0;
        int[] sorted = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            var first = rightptr == right.Length || ((leftptr < left.Length) && (left[leftptr] <= right[rightptr]));
            var second = leftptr == left.Length || ((rightptr < right.Length) && (right[rightptr] <= left[leftptr]));
            if (first) sorted[i] = left[leftptr++];
            else if(second) sorted[i] = right[rightptr++];
        }
        return sorted;
    }
}

using System.Diagnostics;

namespace CsharpLeetCode.Main.Medium;
public class MyTripleSum
{
    private static List<int[]> TwoSum(int[] nums, int target,int exceptedIndex)
    {
        var map = new Dictionary<int, int>();
        var result = new List<int[]>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (i == exceptedIndex) continue;

            int otherNumber = target - nums[i];
            if (map.ContainsKey(otherNumber)) result.Add(new int[] { otherNumber, nums[i] });
            else map.TryAdd(nums[i], i);
        }
        return result;
    }

    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(nums[i])) continue;
            map.Add(nums[i], i);
            
            var target = 0 - nums[i];                       
            var twoSumCheck = TwoSum(nums, target,i);
            if (twoSumCheck.Count == 0) continue;

            foreach (var doubles in twoSumCheck)
            {
                var toAdd = new List<int>(doubles) { nums[i] }.ToArray();
                Array.Sort(toAdd);
                var isExisted = false;
                foreach (var list in result)
                {
                    isExisted = Enumerable.SequenceEqual(toAdd, list.ToArray());
                    if(isExisted) break;
                }
                if (isExisted) continue;
                result.Add(toAdd.ToList());
            }
        }
        return result;
    }
}

public class TripleSum // По чужому решению
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();
        Array.Sort(nums);
        var length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            if(i>0 && nums[i] == nums[i-1]) continue;

            int left = i + 1;
            int right = length - 1;

            while (left < right)
            {
                var checkSum = nums[i] + nums[left] + nums[right];
                if (checkSum > 0) right--;
                else if (checkSum < 0) left++;
                else
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    left++;
                    while (nums[left] == nums[left - 1] && left < right) left++;
                }
            }
        }
        return result;
    }
}


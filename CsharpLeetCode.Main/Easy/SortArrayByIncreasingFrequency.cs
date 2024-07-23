namespace CsharpLeetCode.Main.Easy;
public class SortArrayByIncreasingFrequency
{
    private static Dictionary<int,int> GetFreqMap(int[] nums)
    {
        var mapFreq = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (mapFreq.ContainsKey(nums[i]))
            {
                mapFreq[nums[i]]++;
                continue;
            }
            mapFreq.Add(nums[i], 1);
        }
        return mapFreq;
    }
    public int[] FrequencySort(int[] nums)
    {
        var mapFreq = GetFreqMap(nums);
        for(int i = 0;i < nums.Length; i++)
        {
            bool isSwaped = false;
            for (int j = 0; j < nums.Length - 1 - i; j++)
            {
                if (mapFreq[nums[j]] > mapFreq[nums[j + 1]] 
                    || (mapFreq[nums[j]] == mapFreq[nums[j + 1]] && nums[j] < nums[j + 1]))
                {
                    (nums[j + 1], nums[j]) = (nums[j], nums[j + 1]);
                    isSwaped = true;
                }
            }
            if (!isSwaped) break;
        }
        return nums;
    }
}


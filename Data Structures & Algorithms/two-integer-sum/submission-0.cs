public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict = new();
        int[] res = new int[2];

        for(int i =0; i<nums.Length; i++)
        {
            if(dict.ContainsKey(target - nums[i]))
            {
                res[0] = dict[target-nums[i]];
                res[1] = i;
                return res;
            }
            else
            {
                dict[nums[i]] = i; 
            }
        }

        return res;
    }
}

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict = new();
    for (int i = 0; i < nums.Length; i++) {
        if (dict.TryGetValue(target - nums[i], out int j)) {
            return new int[] { j, i };
        }
        dict[nums[i]] = i;
    }
    return Array.Empty<int>();
    }
}

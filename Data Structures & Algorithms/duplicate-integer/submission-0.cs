public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> dup = new();

        foreach(var num in nums)
        {
            if(dup.ContainsKey(num)) return true;

            dup.Add(num,num);
        }

        return false;
    }
}
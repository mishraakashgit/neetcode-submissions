public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new (nums);
        int longest = 0;

        foreach(var num in nums)
        {
            if(!set.Contains(num-1))
            {
                int length = 1;
                while(set.Contains(num + length))
                {
                    length++;
                }

                longest = Math.Max(length,longest);
            }
        }

        return longest;
    }
}

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int L = 1;
        int R = 1;
        int s = nums.Length;

        int[] sum = new int[s];

        for(int i = 0; i<s; i++)
        {
            sum[i] = L;
            L = L * nums[i];
        }

        for(int j = s - 1; j>=0; j--)
        {
            sum[j] = R * sum[j];
            R = R * nums[j];
        }

        return sum;
    }
}

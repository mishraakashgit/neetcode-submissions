public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea = 0;
        int i = 0;
        int j = heights.Length - 1;
        int currArea = 0;

        while(i<j)
        {
            currArea = Math.Min(heights[i],heights[j]) * (j - i);
            maxArea = Math.Max(currArea,maxArea);

            if(heights[j]>heights[i]) i++;
            else j--;
        }

        return maxArea;
    }
}

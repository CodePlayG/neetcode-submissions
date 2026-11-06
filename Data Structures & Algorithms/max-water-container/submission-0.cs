// using System.Math
public class Solution {
    public int MaxArea(int[] heights) {
        int j=heights.Length -1;
        int i =0;
        int mArea =0;
        while(i<j)
        {
            int cArea = Math.Min(heights[i], heights[j]) *(j-i);
           mArea = Math.Max(mArea, cArea);
            if(heights[i]<heights[j])
            i++;
            else
            j--;
        }
        return mArea;
    }
}

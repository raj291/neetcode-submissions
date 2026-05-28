public class Solution {
    public int MaxArea(int[] heights) {
        int area = 0;
        int l = 0 ;
        int r = heights.Length - 1;
        while(l < r){
            int res = (Math.Min(heights[l] , heights[r])) * (r - l);
            area = Math.Max(area,res);
            if(heights[l]<= heights[r]){
                l++;
            }else {
                r--;
            }
        }
        return area;

    }
}

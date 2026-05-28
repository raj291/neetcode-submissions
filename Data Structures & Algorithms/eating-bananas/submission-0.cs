public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int slow = 1;
        int fast = piles.Max();
        int res = fast;
        while(slow <= fast){
            int speed = (slow + fast) / 2;
            long totalTime = 0;
            foreach(int pile in piles){
                totalTime += (int)Math.Ceiling((double)pile/speed);
            }
            if(totalTime <= h){
                res = speed;
                fast = speed - 1;
            } else{
                slow = speed + 1;
            }
        }
        return res;
    }
}

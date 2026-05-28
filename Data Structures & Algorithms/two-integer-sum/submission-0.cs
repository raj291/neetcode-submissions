public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> maping = new Dictionary<int,int>();
        for(int i = 0 ; i < nums.Length ; i++){
            var diff = target - nums[i];
            if(maping.ContainsKey(diff)){
                return new int[]{maping[diff], i};
            }
            maping[nums[i]]= i;

        }
        return null;
    }
}

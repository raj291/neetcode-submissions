class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums) {
        var hasSet = new Set();
        for(let i = 0 ; i < nums.length ; i++){
            if(hasSet.has(nums[i])){
                return true;
            }
            else{
                hasSet.add(nums[i]);
            }
        }
        return false;
    }
}

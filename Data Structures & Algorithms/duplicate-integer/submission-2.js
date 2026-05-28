class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums) {
        let duplicates = {};
        for(let i = 0 ; i < nums.length ; i++){
           if(duplicates[nums[i]]){
            return true;
           }
           duplicates[nums[i]] = 1
        }
        return false
    }
}

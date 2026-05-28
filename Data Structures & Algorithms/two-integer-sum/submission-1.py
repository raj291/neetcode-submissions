class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        two_sums = {}
        for i in range(len(nums)):
            diff = target - nums[i]
            if diff in two_sums:
                return [two_sums[diff] , i]
            
            two_sums[nums[i]] = i
                
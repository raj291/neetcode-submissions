class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        if not nums:
            return 0
        
        curr = 1
        long = 1
        nums = sorted(set(nums))
        for i in range(1 , len(nums)):
            if nums[i] == nums[i - 1] + 1:
                curr += 1
                long = max(curr , long)
            else:
                curr = 1
        
        return long
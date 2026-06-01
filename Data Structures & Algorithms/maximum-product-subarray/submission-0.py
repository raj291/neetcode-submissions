class Solution:
    def maxProduct(self, nums: List[int]) -> int:
        minn = nums[0]
        maxx = nums[0]
        result = maxx

        for i in range(1, len(nums)):
            curr = nums[i]
            temp = max(curr , maxx * curr , minn * curr)
            minn = min(curr , minn*curr , maxx*curr)
            maxx = temp
            result = max(result , maxx)
        return result



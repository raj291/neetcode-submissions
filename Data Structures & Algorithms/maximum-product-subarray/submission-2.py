class Solution:
    def maxProduct(self, nums: List[int]) -> int:
        minn = nums[0]
        maxx = nums[0]
        result = maxx

        for i in range(1 , len(nums)):
            curr = nums[i]
            temp = max(curr , curr * maxx , curr * minn)
            minn = min(curr , curr * maxx , curr * minn)
            maxx = temp
            result = max(result , maxx)

        return result 



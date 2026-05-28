class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        row = len(matrix)
        col = len(matrix[0])
        left = 0
        right = row * col - 1
        while left <= right:
            mid = (left + right) // 2
            mid_value = matrix[mid // col][mid % col]
            if mid_value == target:
                return True
            elif target < mid_value:
                right = mid - 1
            else :
                left = mid + 1
        return False
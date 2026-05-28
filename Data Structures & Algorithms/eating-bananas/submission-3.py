import math
class Solution:
    def minEatingSpeed(self, piles: List[int], h: int) -> int:
        max_speed = max(piles)
        min_speed = 1
        result = max_speed
        while min_speed <= max_speed:
            avg_speed = (max_speed + min_speed) // 2 ;
            total_time = 0
            for pile in piles:
                total_time += math.ceil(float(pile) / avg_speed)
            if total_time <= h:
                result = avg_speed
                max_speed = avg_speed - 1 
            else :
                min_speed = avg_speed + 1
        return result

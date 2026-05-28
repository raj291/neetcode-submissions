class Solution:
    def carFleet(self, target: int, position: List[int], speed: List[int]) -> int:
        stack = []
        pair = [[p , sp] for p , sp in zip(position , speed)]
        pair.sort(reverse = True)
        for p , sp in pair:
            stack.append((target - p)/sp)
            if len(stack) >= 2 and stack[-1] <= stack[-2]:
                stack.pop()
        return len(stack)
        
        
class Solution:
    def evalRPN(self, tokens: List[str]) -> int:
        result = []
        for token in tokens:
            if token == "+":
                result.append(result.pop() + result.pop())
            elif token == "-":
                a , b = result.pop() , result.pop()
                result.append(b - a)
            elif token == "*":
                result.append(result.pop() * result.pop())
            elif token == "/":
                a , b = result.pop() , result.pop()
                result.append(int(float(b)/a))
            else :
                result.append(int(token))

        return result[0]
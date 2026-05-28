public class Solution {
    public bool IsPalindrome(string s) {
       s = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();
       int end = s.Length - 1;
       for(int i = 0 ; i < s.Length / 2 ; i++){
        if(s[i] != s[end]){
            return false;
        }
        end--;
       }
       return true;
    }
}

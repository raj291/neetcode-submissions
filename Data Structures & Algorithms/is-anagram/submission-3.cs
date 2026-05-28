public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> ana = new Dictionary<char,int>();
        Dictionary<char, int> gram = new Dictionary<char, int>();
        if(s.Length != t.Length){
            return false;
        }
        for(int i = 0 ; i < s.Length ; i++){
            ana[s[i]] = ana.GetValueOrDefault(s[i], 0) + 1;
            gram[t[i]] = gram.GetValueOrDefault(t[i], 0) + 1;

        }
        
        return ana.Count == gram.Count && !ana.Except(gram).Any();
    }
}

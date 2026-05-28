public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
     if(strs.Length == 0){
        return new List<List<string>>();
     }   

     Dictionary<string, List<string>> groupAna = new();
     foreach(var word in strs){
        int[] count = new int[26];
        foreach(char c in word){
            count[c - 'a']++;
        }
        string key = string.Join(",",count);
        if(!groupAna.ContainsKey(key)){
            groupAna[key] = new List<String>();
        }
        groupAna[key].Add(word);
     }
     return groupAna.Values.ToList<List<string>>();
    }
}

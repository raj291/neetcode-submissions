public class Solution {

    public string Encode(IList<string> strs) {
        string res = "";
        for(int i = 0 ; i < strs.Count ; i++){
            res += strs[i].Length + "#" + strs[i];
        }
        return res;
    }

    public List<string> Decode(string s) {
        List<string> res = new List<string>();
        int i = 0;
        while(i < s.Length){
            int j = s.IndexOf('#',i);
            int length = int.Parse(s.Substring(i , j - i));
            string word = s.Substring(j + 1, length);
            res.Add(word);
            i = j + 1 + length;
        }
        return res;
   }
}

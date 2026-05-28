class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s, t) {
        let ana = {}
        let gram = {}
        if(s.length !== t.length){
            return false;
        }
        for(let i = 0 ; i < s.length ; i++){
            ana[s[i]] = (ana[s[i]] || 0) + 1;
            gram[t[i]] = (gram[t[i]] || 0) + 1;
        }
        for(let keys in ana){
            if(ana[keys] !== gram[keys]){
                return false;
            }
        }
        return true;
    }
}

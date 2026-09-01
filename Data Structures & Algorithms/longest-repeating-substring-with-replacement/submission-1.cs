public class Solution {
    public int CharacterReplacement(string s, int k) {
        //string res = s.sort();
        Dictionary<char, int> count = new();
        int l=0, r =0, res=0, max =0;
        for(r =0; r<s.Length; r++)
        {
            count[s[r]]=count.GetValueOrDefault(s[r], 0) + 1;
            max = Math.Max(max, count[s[r]]);

            //shrinking window if replacement exceed k
            while((r-l+1)-max >k){
                count[s[l]]--;
                l++;
            }
            res = Math.Max(res, r-l+1);

        } 
        return res;
    }
}

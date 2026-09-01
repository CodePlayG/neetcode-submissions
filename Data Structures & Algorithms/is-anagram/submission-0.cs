public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length!=t.Length) return false;
        // Dictionary<char, int> countS = new();
        // Dicationary<char, int> countT = new();
        // for (int i=0; i<s.Length; i++){
        //     countS[s[i]]=countS.GetValueOrDefault(s[i],0) +1 ;
        //     countT[t[i]] = countT.GetValueOrDefault(t[i], 0) +1;
        // }
        //compare

        //Big O Time Complexity nlogn() 
        char[] sortS = s.ToCharArray(); 
        char[] sortT = t.ToCharArray();
        Array.Sort(sortS);
        Array.Sort(sortT);

        for(int i=0; i<s.Length; i++){
            if (sortS[i]!=sortT[i])
            return false;
        }
        return true;
    }
}

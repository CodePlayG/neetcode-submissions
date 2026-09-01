public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length!=t.Length) return false;
        Dictionary<char, int> count = new();
        
        for (int i=0; i<s.Length; i++){
            count[s[i]]=count.GetValueOrDefault(s[i],0) +1 ;
            count[t[i]] = count.GetValueOrDefault(t[i], 0) -1;
        }
       // return countS.Count == countT.Count && !countS.Except(countT).Any();
        
        //compare
        foreach(var kvp in count){
            if (kvp.Value!=0) return false;
        }
        return true;
        //Big O Time Complexity nlogn() 
            // char[] sortS = s.ToCharArray(); 
            // char[] sortT = t.ToCharArray();
            // Array.Sort(sortS);
            // Array.Sort(sortT);

            // for(int i=0; i<s.Length; i++){
            //     if (sortS[i]!=sortT[i])
            //     return false;
            // }
            // return true;
    }
}

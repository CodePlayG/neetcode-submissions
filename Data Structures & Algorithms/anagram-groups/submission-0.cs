public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> res = new();
                 
        foreach(string s in strs){
            Dictionary<char, int> freq= new();
            foreach(char c in s){
                freq[c]=freq.GetValueOrDefault(c, 0)+1;

            }
                var sb  = new StringBuilder();
                foreach(var kvp in freq.OrderBy(kvp=>kvp.Key)){
                    sb.Append(kvp.Key);
                    sb.Append(":");
                    sb.Append(kvp.Value);
                  //  sb.Append(";");
                }
                string key = sb.ToString();

                
                if(!res.ContainsKey(key)){
                    res[key]=new List<string>();
                }
                res[key].Add(s);

        }
        return res.Values.ToList();

    }

}

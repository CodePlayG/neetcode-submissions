public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new();
        int[]res = new int[k];
        foreach(int  n in nums){
            map[n]= map.GetValueOrDefault(n, 0) +1;
        }
       // return map.OrderByDescending(x=>x.Value).Take(k).Select(x=>x.Key).ToArray();
        
        for(int i=0; i<k; i++ ){
            int max = int.MinValue;
            int maxKey =0;
            foreach (var kvp in map){
                if(kvp.Value>max){
                    max=kvp.Value;
                    maxKey = kvp.Key;
                }
                res[i]=maxKey;
            }
            map.Remove(maxKey);
            
        }

    return res;
    }
}

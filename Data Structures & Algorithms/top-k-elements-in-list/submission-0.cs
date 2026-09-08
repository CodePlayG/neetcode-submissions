public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new();
        int[]res = new int[k];
        foreach(int  n in nums){
            map[n]= map.GetValueOrDefault(n, 0) +1;

        }
        return map.OrderByDescending(x=>x.Value).Take(k).Select(x=>x.Key).ToArray();
        // res = map.Values.ToArray();
        // for(int i=0; i<k; i++){
        //     //Math.Max(map.Value[i])
        //   //  res.Add(map.Values)
        // }
        
    }
}

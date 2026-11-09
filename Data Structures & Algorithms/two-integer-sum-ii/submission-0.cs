public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int, int> map = new();
        for(int i=0; i<numbers.Length; i++)
        {
            int val = target - numbers[i];
           // map.ToValueOrDefault(0, )
            // map[i]if(target-numbers[i]
            if(map.ContainsKey(val)){
                return new int[]{map[val]+1, i+1};

            }
            map[numbers[i]] = i;
        
        }
        return new int[]{};
    }
}

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       Dictionary<int, int> map = new();
       
       for(int i=0; i<nums.Length; i++){
        int comp = target -nums[i];

        if(map.ContainsKey(comp)){
            return new int[] {map[comp],i};
        }
        if(!map.ContainsKey(nums[i])){
            map[nums[i]] =i;
        }
       }         
         return new int[]{};  
        }

    }

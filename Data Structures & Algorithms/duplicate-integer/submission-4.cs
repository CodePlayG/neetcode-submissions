public class Solution {
    public bool hasDuplicate(int[] nums) {
        if(nums.Length<=1) return false;
        HashSet<int> items = new();
       foreach(int n in nums){
       
        if(!(items.Add(n)))
            return true;
       }            
         return false;
               
    }
}
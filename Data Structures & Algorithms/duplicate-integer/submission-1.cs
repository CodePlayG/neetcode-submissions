public class Solution {
    public bool hasDuplicate(int[] nums) {
       HashSet<int> items = new();
       foreach(int n in nums){
        if(!(items.Add(n)))
            return true;
       }            
         return false;
               
    }
}
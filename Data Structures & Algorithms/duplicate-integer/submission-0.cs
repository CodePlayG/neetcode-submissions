public class Solution {
    public bool hasDuplicate(int[] nums) {
       
        Dictionary<int, int> items = new();
        foreach(int n in nums){
            if(items.ContainsKey(n)){
                return true;
            }
            else
                items[n] =1;
            
            
        }
         
         return false;
               
    }
}
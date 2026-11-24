public class Solution {
    public bool IsValid(string s) {
        //bool isValid = false;
        if ((s.Length)%2==1) return false;
       Stack<char> st = new ();
        foreach(char c in s){
            if(c=='(' || c=='{' || c=='['){
                st.Push(c);
            }                
            else 
            {
                if(st.Count==0) return false;
                char top = st.Pop();
                if (c==')' && top!='(' || c=='}' && top!='{' || c==']' && top!='[')
                {
                    return false;
                }
               
                               
            }            
        }
        return st.Count==0 ;
    }
}

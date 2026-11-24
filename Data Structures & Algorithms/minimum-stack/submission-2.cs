public class MinStack {
private Stack<int> stak;
private Stack<int> minStack;
    public MinStack() {
       stak = new();
       minStack = new();
    }
    
    public void Push(int val) {
        stak.Push(val);
        if(minStack.Count==0 || val<=minStack.Peek()){
            minStack.Push(val);
        }
        
    }
    
    public void Pop() {
        if(stak.Peek()==minStack.Peek()){
            minStack.Pop();
        }
        stak.Pop();
        // if()
    }
    
    public int Top() {
       return stak.Peek();
    }
    
    public int GetMin() {
       return minStack.Peek();
        
    }
}

public class KthLargest {
    private PriorityQueue<int, int> pq;
    private int k;
    public KthLargest(int k, int[] nums) {
        this.k= k;
        pq= new PriorityQueue<int, int>();
        foreach(int n in nums){
            Add(n);
        }
    }
    
    public int Add(int val) {
        pq.Enqueue(val, val);
        if(pq.Count>k){
            pq.Dequeue();
        }
        return pq.Peek();
    }
}

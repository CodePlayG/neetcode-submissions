public class WordDictionary {
    private List<string> words;
    public WordDictionary() {
        words = new();
    }
    
    public void AddWord(string word) {
        words.Add(word);
    }
    
    public bool Search(string word) {
        foreach(string w in words){
            if(w.Length!=word.Length) continue;
            int i=0;
            while(i<word.Length){
                if(w[i]==word[i] || word[i]=='.'){
                    i++;
                }
                else{
                    break;
                }
            }
            if(i ==w.Length){
                return true;
            }
        }
        return false;
    }
}

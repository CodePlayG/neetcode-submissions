public class Solution {
    public int CharacterReplacement(string s, int k) {
        //string res = s.sort();
        int[] count = new int[26];   // frequency of each character
        int left = 0, maxf = 0, res = 0;

        for (int right = 0; right < s.Length; right++) {
            // Update frequency of current character
            count[s[right] - 'A']++;
            maxf = Math.Max(maxf, count[s[right] - 'A']);

            // If window is invalid, shrink from left
            while ((right - left + 1) - maxf > k) {
                count[s[left] - 'A']--;
                left++;
            }

            // Update result with valid window size
            res = Math.Max(res, right - left + 1);
        }

        return res;
        
    }
}

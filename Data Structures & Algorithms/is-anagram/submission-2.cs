public class Solution {
    public bool IsAnagram(string s, string t) {
            char [] arrayS = s.ToCharArray(); Array.Sort(arrayS);
            char [] arrayT = t.ToCharArray(); Array.Sort(arrayT);

            return new String(arrayS) == new String(arrayT);       
    }
}

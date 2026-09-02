public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s==null || t == null){
            return true;
        }

        char [] ss = s.ToCharArray();
        char [] tt = t.ToCharArray();

        Array.Sort(ss);
        Array.Sort(tt);

        if(ss.Length != tt.Length){
            return false;
        }


        if(new string(ss) == new string(tt)){
            return true;
        }

        return false;
    }
}

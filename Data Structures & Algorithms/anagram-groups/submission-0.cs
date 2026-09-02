public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if(strs==null){
            List<List<string>> final = new List<List<string>>();
            return final;
        }
    List<List<string>> definer = new List<List<string>>();

for(int i = 0; i<strs.Length; i++){

    bool done = false;
    char [] ss = strs[i].ToCharArray();
    Array.Sort(ss);

    string sfinal = new string (ss);

    for (int j = 0; j < definer.Count; j++) {
        char [] tt = definer[j][0].ToCharArray();
        
        Array.Sort(tt);

       
       string tfinal =  new string (tt);

        if(sfinal==tfinal){
            definer[j].Add(strs[i]);
            done = true;
            break;
        }       
    }


    if(!done){
            definer.Add( new List<string> { strs[i]});
        }

}

    



        return definer;
    }
}

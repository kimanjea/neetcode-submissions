public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        HashSet<int> set = new HashSet<int>();

int i=0;
while (i < nums.Length) {


        if(set.Contains(nums[i])){

            return true;
        } else {

            set.Add(nums[i]);
        }

    i++;
}
        return false;
    }
}
https://leetcode.com/problems/two-sum/submissions/1717087305/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        for(int i=0; i<nums.Length-1; i++){
            for(int j=i+1; j<nums.Length; j++){
                if(nums[i]+nums[j] == target){
                    result[0] = i;
                    result[1] = j;
                }
            }
        }
        return result;
    }
}

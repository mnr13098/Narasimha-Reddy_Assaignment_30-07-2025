https://leetcode.com/problems/rotate-array/submissions/1717170803/?envType=study-plan-v2&envId=top-interview-150

public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        int[] ans = new int[n];
        for(int i=0; i<n; i++){
            ans[(i+k)%n]=nums[i];
        }
        for(int i=0; i<n; i++){
            nums[i]=ans[i];
        }
    }
}

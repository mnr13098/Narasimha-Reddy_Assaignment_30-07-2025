
https://leetcode.com/problems/median-of-two-sorted-arrays/submissions/1717165351/

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int n1 = nums1.Length;
        int n2 = nums2.Length;
        int[] arr = new int[n1+n2];
        int i = 0;
        int j = 0;
        int count = 0;
        while(i<n1 && j<n2){
            if(nums1[i]<nums2[j]){
                arr[count++] = nums1[i++];
            }
            else {
                arr[count++] = nums2[j++];
            }
        }
        while (i < n1) arr[count++]=nums1[i++];
        while (j < n2) arr[count++]=nums2[j++];

        int n = n1 + n2;

        if (n % 2 == 1)
        {
            return (double)arr[n / 2];
        }

        double median = ((double)arr[n / 2] + (double)arr[(n / 2) - 1]) / 2.0;
        return median;
    }
}

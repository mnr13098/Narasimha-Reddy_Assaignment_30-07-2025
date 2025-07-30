https://leetcode.com/problems/valid-palindrome/submissions/1717198071/?envType=study-plan-v2&envId=top-interview-150

using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        string cleaned = Regex.Replace(s, "[^a-zA-Z0-9]", "");
        string finall = cleaned.ToLower();
        int n = finall.Length;
        int i=0;
        int j = n-1;
        while(i<=j){
           if(finall[i]!=finall[j]) return false;
           else {
            i++;
            j--;
           }
        }
        return true;
    }
}

/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome
 */

// @lc code=start
public class Solution {
       public bool IsPalindrome(int x) {
       int r=0, c=x;
        while(c>0)
        {
            r=r*10+c%10;
            c=c/10;
        }
    return r==x;
    }
}
// @lc code=end


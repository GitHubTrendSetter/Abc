/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */

// @lc code=start
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        //null check
        if(strs==null || strs.Length<1)
        return "";

        //Problem constraints show max string length does not exceed 200, so set min length to max value
        int minLength=200;

        //find minimum string from strs
        foreach(var s in strs)
            minLength=Math.Min(minLength,s.Length);
        //loop through each character of min string
        //set each character as base character from first string
        for(int i=0;i<minLength;i++)
         {
            //base character
            var c=strs[0][i];

            //loop through all strings
            for(int j=1;j<strs.Length;j++)
            {
                //if current string character is not matching with base character
                //return substring before current base character.
                if(strs[j][i]!=c)
                    return strs[0].Substring(0,i);
            }
        }
        //return base string itself for successful case for all strings
        return strs[0].Substring(0,minLength);
    }
}
// @lc code=end


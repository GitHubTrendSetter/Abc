/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
public class Solution {
    public bool IsValid(string s) {
        //null check is not required based on contraints given

        //store begin and end brackets in a dictionary
        var dict=new Dictionary<char,char>{
            {'(',')'},
            {'{','}'},
            {'[',']'}
        };

        Stack stack=new Stack();
        //loop string
        for(int i=0;i<s.Length;i++)
        {
            if(dict.ContainsKey(s[i]))
            {
                stack.Push(dict[s[i]]);
            }
            else
            if(stack.Count>0 && s[i].Equals(stack.Peek()))
             {
                stack.Pop();
             }
             else
                return false;
        }
        //return true if stack is empty
        return stack.Count==0;
    }
}
// @lc code=end


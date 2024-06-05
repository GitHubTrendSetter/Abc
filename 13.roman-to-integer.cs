/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
public class Solution {
    public int RomanToInt(string s) {
        //Approach
        //parse string from right to left
        //IV - if current value (I) is less than previous value (V) - subtract
        //VI - if current value (V) is greater than previous value(I) - add
        var romanValues = new Dictionary<string,int>{
            {"I",1},
            {"V",5},
            {"X",10},
            {"L",50},
            {"C",100},
            {"D",500},
            {"M",1000}
        };
     int total=0;
     int prev=0;
        for(int i=s.Length-1;i>=0;i--){
            int current=romanValues[s[i].ToString()];

            if(current<prev)
             total-=current;
             else
             total+=current;
        
        prev=current;
        }
        return total;
    }
}
// @lc code=end


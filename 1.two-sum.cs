/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
       public int[] TwoSum(int[] nums, int target) {
        var hashMap = new Dictionary<int,int>(){};
        for(var firstNum=0;firstNum<nums.Length;firstNum++)
        {
            var secondNum = target - nums[firstNum];
            if(hashMap.ContainsKey(secondNum))
             return new int[]{firstNum,hashMap[secondNum]};
            hashMap.TryAdd(nums[firstNum], firstNum);
        }
        return new int[]{};
    }
}
// @lc code=end


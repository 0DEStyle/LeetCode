/*Challenge link:https://leetcode.com/problems/number-of-good-pairs/description/
Question:
Given an array of integers nums, return the number of good pairs.

A pair (i, j) is called good if nums[i] == nums[j] and i < j.

 

Example 1:

Input: nums = [1,2,3,1,1,3]
Output: 4
Explanation: There are 4 good pairs (0,3), (0,4), (3,4), (2,5) 0-indexed.
Example 2:

Input: nums = [1,1,1,1]
Output: 6
Explanation: Each pair in the array are good.
Example 3:

Input: nums = [1,2,3]
Output: 0
 

Constraints:

1 <= nums.length <= 100
1 <= nums[i] <= 100
*/

//***************Solution********************public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int res = 0;
        var count = new Dictionary<int, int>();


        foreach(int n in nums){
            if(count.ContainsKey(n)){
                res += count[n];
                count[n]++;
            }
            else
                count[n] = 1;
        }
        return res;
    }
}

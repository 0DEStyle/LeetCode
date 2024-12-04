/*Challenge link:https://leetcode.com/problems/count-odd-numbers-in-an-interval-range/description/
Question:
Given two non-negative integers low and high. Return the count of odd numbers between low and high (inclusive).

 

Example 1:

Input: low = 3, high = 7
Output: 3
Explanation: The odd numbers between 3 and 7 are [3,5,7].
Example 2:

Input: low = 8, high = 10
Output: 1
Explanation: The odd numbers between 8 and 10 are [9].
 

Constraints:

0 <= low <= high <= 10^9
*/

//***************Solution********************

//Then simiplfied into one line by using an Lambda expression with Enumerable methods.

//timed out solution
public class Solution {
    public int CountOdds(int l, int h) =>
    Enumerable.Range(l, h - l + 1).Count(x => x % 2 != 0);
}

public class Solution {
    public int CountOdds(int l, int h) =>
    (l % 2 == 0 && h % 2 == 0) ? (h - l) / 2 : (h - l) / 2 + 1;
}

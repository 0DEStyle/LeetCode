/*Challenge link:https://leetcode.com/problems/day-of-the-year/description/
Question:
Given a string date representing a Gregorian calendar date formatted as YYYY-MM-DD, return the day number of the year.

 

Example 1:

Input: date = "2019-01-09"
Output: 9
Explanation: Given date is the 9th day of the year in 2019.
Example 2:

Input: date = "2019-02-10"
Output: 41
 

Constraints:

date.length == 10
date[4] == date[7] == '-', and all other date[i]'s are digits
date represents a calendar date between Jan 1st, 1900 and Dec 31th, 2019.
*/

//***************Solution********************
using System.Globalization;

public class Solution {
    public int DayOfYear(string date) => 
    DateOnly.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture).DayOfYear;
}

/*Challenge link:https://leetcode.com/problems/keyboard-row/description/
Question:
Given an array of strings words, return the words that can be typed using letters of the alphabet on only one row of American keyboard like the image below.

In the American keyboard:

the first row consists of the characters "qwertyuiop",
the second row consists of the characters "asdfghjkl", and
the third row consists of the characters "zxcvbnm".

//see image in link 

Example 1:

Input: words = ["Hello","Alaska","Dad","Peace"]
Output: ["Alaska","Dad"]
Example 2:

Input: words = ["omk"]
Output: []
Example 3:

Input: words = ["adsdf","sfd"]
Output: ["adsdf","sfd"]
 

Constraints:

1 <= words.length <= 20
1 <= words[i].length <= 100
words[i] consists of English letters (both lowercase and uppercase). 
*/

//***************Solution********************
public class Solution {
        //keyboard row
        static string[] _rows = new string[]{
        "qwertyuiop",
        "asdfghjkl",
        "zxcvbnm",
    };
    public string[] FindWords(string[] words)
        => words.Where(x => _rows.Any(y => x.ToLower().All(z => y.Contains(z))))
                .ToArray();
    }

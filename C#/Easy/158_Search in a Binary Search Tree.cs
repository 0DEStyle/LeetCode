/*Challenge link:https://leetcode.com/problems/search-in-a-binary-search-tree/description/
Question:
You are given the root of a binary search tree (BST) and an integer val.

Find the node in the BST that the node's value equals val and return the subtree rooted with that node. If such a node does not exist, return null.

 

Example 1:
//see image in link

Input: root = [4,2,7,1,3], val = 2
Output: [2,1,3]
Example 2:
//see image in link

Input: root = [4,2,7,1,3], val = 5
Output: []
 

Constraints:

The number of nodes in the tree is in the range [1, 5000].
1 <= Node.val <= 107
root is a binary search tree.
1 <= val <= 107
*/

//***************Solution********************
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SearchBST(TreeNode root, int val) {
        //if null or match
        if(root == null || root.val == val)
             return root;
        
        //check val, go either left or right node.
        return root.val > val ? SearchBST(root.left, val) : 
                                SearchBST(root.right, val);
    }
}

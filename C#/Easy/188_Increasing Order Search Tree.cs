/*Challenge link:https://leetcode.com/problems/increasing-order-search-tree/description/
Question:
/**
Given the root of a binary search tree, rearrange the tree in in-order so that the leftmost node in the tree is now the root of the tree, and every node has no left child and only one right child.

 

Example 1:
//see image in link

Input: root = [5,3,6,2,4,null,8,1,null,null,null,7,9]
Output: [1,null,2,null,3,null,4,null,5,null,6,null,7,null,8,null,9]
Example 2:
//see image in link


Input: root = [5,1,7]
Output: [1,null,5,null,7]
 

Constraints:

The number of nodes in the given tree will be in the range [1, 100].
0 <= Node.val <= 1000

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
     TreeNode curr = null;

    private void inorder(TreeNode root){
        if(root == null)
            return;
        inorder(root.left);
        //add right node to curr
        curr.right = new TreeNode(root.val);
        curr = curr.right;
        inorder(root.right);
    }

    public TreeNode IncreasingBST(TreeNode root) {
        var ptr = new TreeNode(-1);
        curr = ptr;
        inorder(root);
        return ptr.right;
    }
}

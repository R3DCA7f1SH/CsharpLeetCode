﻿using CsharpLeetCode.Main.Medium.DataStructure;

namespace CsharpLeetCode.Main.Easy;
public class PathSumSolution
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if(root == null) return false;
        if (root.left == null && root.right == null) return root.val == targetSum;
        return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
    }
}

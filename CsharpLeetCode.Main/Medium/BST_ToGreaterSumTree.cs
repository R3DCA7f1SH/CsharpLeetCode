namespace CsharpLeetCode.Main.Medium
{
    using CsharpLeetCode.Main.Medium.DataStructure;
    
    // Задача: https://leetcode.com/problems/binary-search-tree-to-greater-sum-tree
    public class BST_ToGreaterSumTree
    {
        private static Dictionary<int,int> GetSumMap(TreeNode node, Dictionary<int, int> accum)
        {
            if (node == null) return accum;
            var newDict = new Dictionary<int, int>(accum);
            newDict.Add(node.val,node.val);
            foreach(var item in newDict)
            {
                var currentKey = item.Key;
                var currentValue = item.Value;

                var keys = newDict.Keys.Where(s=>s>item.Key);
                newDict[currentKey] = keys.Sum();
            }
            newDict = GetSumMap(node.left, newDict);
            newDict = GetSumMap(node.right, newDict);
            return newDict;
        }
       

        private static TreeNode UpdateBstByDict(TreeNode node, Dictionary<int, int> accum)
        {
            if (node == null) return null;
            node.val += accum[node.val];
            UpdateBstByDict(node.left, accum);
            UpdateBstByDict(node.right, accum);
            return node;
        }

        public TreeNode BstToGst(TreeNode root) 
        { 
            var newDict = new Dictionary<int,int>();
            var updatedDict = GetSumMap(root, newDict);            
            var result = UpdateBstByDict(root, updatedDict);
            return result;            
        }

        //return UpdateBstBySum(root, SumAllBstNode(root)); 
    }

    public class BST_ToGreaterSumTree_Optimized
    {
        public TreeNode BstToGst(TreeNode root)
        {
            int max = 0;
            CheckInOrder(root,ref max);
            return root;
        }

        private static void CheckInOrder(TreeNode n, ref int max)
        {
            if (n == null) return;
            CheckInOrder(n.right, ref max); // Обход справа налево, от больших значений к меньшим
            max = n.val += max; // Максимуму присваивается сумма текущего узла с предыдущим максимумом
            CheckInOrder(n.left, ref max);
        }
    }
}

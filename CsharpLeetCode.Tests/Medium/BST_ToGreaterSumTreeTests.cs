using CsharpLeetCode.Main.Medium;
using CsharpLeetCode.Main.Medium.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLeetCode.Tests.Medium
{
    public  class BST_ToGreaterSumTreeTests
    {
        private readonly BST_ToGreaterSumTree _ToGreaterSumTree = new();
        [Fact]
        public void FirstCase()
        {
            var oldRoot = new TreeNode()
            {
                val = 4,
                left=new TreeNode()
                {
                    val=1,
                    left=new TreeNode()
                    {
                        val = 0
                    },
                    right=new TreeNode()
                    {
                        val=2,
                        right=new TreeNode()
                        {
                            val=3
                        }
                    }
                },
                right=new TreeNode()
                {
                    val=6,
                    left=new TreeNode()
                    {
                        val = 5
                    },
                    right = new TreeNode()
                    {
                        val=7,
                        right=new TreeNode()
                        {
                            val=8
                        }
                    }
                }
            };

            var newRoot = _ToGreaterSumTree.BstToGst(oldRoot);
        }
    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLeetCode.Main.Medium
{
    public class PartitionIntoMinNumOfDeciBinaryNum
    {
        public int MinPartitions(string n)
        {
            int length = n.Length;
            int limit = length / 2 + 1;
            for (int i = 9; i > 0; i--)              
                for (int j = 0; j < limit; j++) 
                    if (n[j] - '0' == i || n[length - 1 - j] - '0' == i) return i;                   
            return 0;
        }
    }
}

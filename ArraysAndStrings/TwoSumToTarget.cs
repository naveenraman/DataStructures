using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.ArraysAndStrings
{
    //Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    //You may assume that each input would have exactly one solution, and you may not use the same element twice.
    //Time complexity : O(n). We traverse the list containing nn elements only once. Each look up in the table costs only O(1)O(1) time.
    //Space complexity : O(n). The extra space required depends on the number of items stored in the hash table, which stores at most nn elements.
    public class TwoSumToTarget
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                    return new int[] { map[complement], i };
                if (!map.ContainsKey(nums[i]))
                    map.Add(nums[i], i);
            }
            throw new Exception("No two sum solution");
        }
    }
}

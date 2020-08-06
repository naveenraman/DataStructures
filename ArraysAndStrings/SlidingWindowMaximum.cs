using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.ArraysAndStrings
{
    //Given an array nums, there is a sliding window of size k which is moving from the very left of the array to the very right. 
    //You can only see the k numbers in the window. Each time the sliding window moves right by one position. Return the max sliding window.
    //solve it in linear time
    //Time complexity : O(N), since all we do is 3 passes along the array of length N.
    //Space complexity : O(N) to keep left and right arrays of length N, and output array of length N - k + 1.
    public class SlidingWindowMaximum
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            int[] left = new int[nums.Length];
            int[] right = new int[nums.Length];
            int[] result = new int[nums.Length - k + 1];
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % k == 0) 
                    max = nums[i];
                max = Math.Max(max, nums[i]);
                left[i] = max;
            }
            max = nums[nums.Length - 1];
            for (int i = nums.Length - 1; i > 0; i--)
            {
                max = Math.Max(max, nums[i]);
                right[i] = max;
                if (i % k == 0) 
                    max = nums[i - 1];
            }
            max = Math.Max(max, nums[0]);
            right[0] = max;
            for (int i = 0; i < nums.Length - k + 1; i++)
                result[i] = Math.Max(right[i], left[i + k - 1]);
            return result;
        }
    }
}

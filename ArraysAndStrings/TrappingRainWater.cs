using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.ArraysAndStrings
{
    //Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.
    //Time complexity: O(n). Single iteration of O(n).
    //Space complexity: O(1) extra space. Only constant space required for left, right, left_max and right_max.
    public class TrappingRainWater
    {
        public int Trap(int[] height)
        {
            if (height.Length == 0) return 0;
            int ans = 0;
            int left = 0;
            int right = height.Length - 1;
            int leftMax = 0;
            int rightMax = 0;
            while (left < right)
            {
                leftMax = height[left] > leftMax ? height[left] : leftMax;
                rightMax = height[right] > rightMax ? height[right] : rightMax;
                if (leftMax < rightMax)
                {
                    ans += Math.Max(0, leftMax - height[left]);
                    left++;
                }
                else
                {
                    ans += Math.Max(0, rightMax - height[right]);
                    right++;
                }
            }
            return ans;
        }
    }
}

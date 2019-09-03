using System;
using System.Collections.Generic;

namespace LeetCode
{
    //给定一个整数数组 nums 和一个目标值 
    //target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
    //
    //你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。
    //
    //示例:
    //
    //给定 nums = [2, 7, 11, 15], target = 9
    //
    //因为 nums[0] + nums[1] = 2 + 7 = 9
    //所以返回 [0, 1]
    //
    //链接：https://leetcode-cn.com/problems/two-sum

    /// <summary>
    /// 
    /// </summary>
    public class Sample1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = { };
            bool found = false;
            for (int i = 0; i < nums.Length - 1;i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result = new int[2] { nums[i], nums[j] };
                        found = true;
                        break;
                    }
                }
                if(found)
                {
                    break;
                }
            }
            return result;
        }
        
        public int[] TwoSum_1(int[] nums, int target)
        {
            int count = nums.Length;
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[2] { i, j };
                    }
                }
            }
            return new int[] { };
        }

        public int[] TwoSum_2(int[] nums, int target)
        {
            Dictionary<int, int> contain = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (contain.ContainsKey(target - nums[i])) return new int[] { contain[target - nums[i]], i };
                else if (!contain.ContainsKey(nums[i])) contain.Add(nums[i], i);
            }
            return new int[] { 0, 0 };
        }
    }
}

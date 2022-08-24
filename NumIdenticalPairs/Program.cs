using System;
using System.Collections.Generic;

namespace NumIdenticalPairs
{


    class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var numsVisited = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (numsVisited.ContainsKey(diff))
                {
                    int[] res = new int[] { numsVisited[diff], i };
                    return res;
                }
                else
                {
                    numsVisited.Add(nums[i], i);
                }

            }
            return new int[] { 0, 0 };
        }
        static void Main(string[] args)
        {
            int[] res = { 11, 7, 2, 15 };
            int target = 9;
            int [] result = (TwoSum(res, target));
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}

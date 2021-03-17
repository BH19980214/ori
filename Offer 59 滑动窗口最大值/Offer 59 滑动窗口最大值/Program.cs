using System;
using System.Collections.Generic;

namespace Offer_59_滑动窗口最大值
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3));
        }

        public static int[] MaxSlidingWindow(int[] nums, int k)
        {
            List<int> num = new List<int>();
            List<int> hua = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hua.Count < k)
                {
                    hua.Add(nums[i]);
                }
                if (hua.Count == k)
                {
                    int max = int.MinValue;
                    for (int j = 0; j < hua.Count; j++)
                    {
                        if (hua[j] > max)
                        {
                            max = hua[j];
                        }
                    }
                    num.Add(max);
                    hua.RemoveAt(0);
                }
            }
            return num.ToArray();


        }


    }
}

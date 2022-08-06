using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LeetCode1
    {
        public void Do()
        {
            var res = TwoSum(new int[] { 2, 71, 11, 7 },9);
            Console.WriteLine("ans is:");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
        }

        /// <summary>
        /// 2层for循环，暴力破解法
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum1(int[] nums, int target)
        {
            int[] ans = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if((nums[i] + nums[j]) == target)
                    {
                        ans[0] = i;
                        ans[1] = j;
                        break;
                    }
                }
            }
            return ans;
        }

        /// <summary>
        /// 哈希法，居然一次通过了
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            int len = nums.Length;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < len; i++)
            {
               if(dic.ContainsKey(target - nums[i]))
                {
                    return new int[] { i,dic[target - nums[i]] };
                }
                dic[nums[i]] = i;
            }
            return new int[0];
            
        }
    }
}

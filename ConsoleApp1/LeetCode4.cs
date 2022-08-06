using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LeetCode4
    {
        public void Do()
        {
            Console.WriteLine(LongestCommonPrefix(new string[] { "ab", "a", }));
        }
        public string LongestCommonPrefix(string[] strs)
        {
           if(strs.Length ==1)
            {
                return strs[0];
            }
            string res = "";
            int len = strs.Length;
            int k = 0;
            int firstLen = strs[0].Length;

            while(true)
            {
                if (k >= firstLen)
                {
                    break;
                }

                bool flag = true;

                for (int i = 1; i < len; i++)
                {
                    if (k >= strs[i].Length)
                    {
                        flag = false;
                    }
                    else if (strs[i][k] != strs[0][k])
                    {
                        flag = false ;
                    }
                }
                if(!flag)
                {
                    break;
                }
                res += strs[0][k];
                k++;
            }

           
            return res;
        }
    }
}

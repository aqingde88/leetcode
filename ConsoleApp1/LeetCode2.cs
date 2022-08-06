using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LeetCode2
    {
      
        public void Do()
        {
            var res = IsPalindrome(11);
            Console.WriteLine(res);
        }

        public bool IsPalindrome2(int x)
        {
            string s = x.ToString();
            int len = s.Length;
            if(len<=1)
            {
                return true;
            }
            for (int i = 0; i < len; i++)
            {
                int l = i;
                int r = len -1 - i;
                if(s[l]!=s[r])
                {
                    return false;
                }
                if(l==r)
                {
                    break;
                }
            }
            return true;
        }

        public bool IsPalindrome(int x)
        {
           if(x<0)
            {
                return false;
            }

           if(x == 0)
            {
                return true;
            }

           if(x%10 == 0)
            {
                return false;
            }

            int left = x;
            int right = 0;

            while(left > right)
            {
                int t = left % 10;
                left /= 10;
                right = right * 10 + t;
                Console.WriteLine(left+","+right);
            }

            if(left == right || left == right/10)
            {
                return true;
            }
            return false;
        }
    }
}

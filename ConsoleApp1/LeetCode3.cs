using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LeetCode3
    {
        /*
        I             1
        V             5
        X             10
        L             50
        C             100
        D             500
        M             1000*

        I 可以放在 V (5) 和 X (10) 的左边，来表示 4 和 9。
        X 可以放在 L (50) 和 C (100) 的左边，来表示 40 和 90。 
        C 可以放在 D (500) 和 M (1000) 的左边，来表示 400 和 900。

        */

        public void Do()
        {
            Console.WriteLine(RomanToInt("IX"));
        }

        public int RomanToInt(string s)
        {
            Dictionary<char, int> numDic = new Dictionary<char, int>();
            numDic['I'] = 1;
            numDic['V'] = 5;
            numDic['X'] = 10;
            numDic['L'] = 50;
            numDic['C'] = 100;
            numDic['D'] = 500;
            numDic['M'] = 1000;

            Dictionary<string, int> specialDic = new Dictionary<string, int>();
            specialDic["IV"] = 4;
            specialDic["IX"] = 9;
            specialDic["XL"] = 40;
            specialDic["XC"] = 90;
            specialDic["CD"] = 400;
            specialDic["CM"] = 900;

            int k = s.Length - 1;
            int res = 0;
            while (k >= 0)
            {
                if ((k - 1) >= 0)
                {
                    string t = s[k - 1].ToString() + s[k].ToString();
                    if (specialDic.ContainsKey(t))
                    {
                        res += specialDic[t];
                        k = k - 2;
                        continue;
                    }
                }

                res += numDic[s[k]];
                k = k - 1;

            }

            return res;
        }
    }
}

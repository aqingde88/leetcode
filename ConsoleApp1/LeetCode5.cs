using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*有效字符串需满足：

左括号必须用相同类型的右括号闭合。
左括号必须以正确的顺序闭合。*/
 

namespace ConsoleApp1
{
    class LeetCode5
    {
        public bool IsValid(string s)
        {
            int len = s.Length;
            if (len < 2)
            {
                return false;
            }
            if (len % 2 != 0)
            {
                return false;
            }
           

            Dictionary<char, char> pairs = new Dictionary<char, char>();
            pairs[')'] ='(';
            pairs[']'] = '[';
            pairs['}'] = '{';

            List<char> chars = new List<char>();

            for (int i = 0; i < len; i++)
            {
                var tmp = s[i];
                //右括号
               if(pairs.ContainsKey(tmp))
               {
                   if(chars.Count == 0)
                    {
                        return false;
                    }
                    if (chars[chars.Count - 1] == pairs[tmp])
                    {
                        chars.RemoveAt(chars.Count - 1);
                    }
                    else
                    {
                        return false;
                    }
               }
               else if (pairs.Values.Contains(tmp))
               {
                    chars.Add(tmp);
               }
               else
                {
                    return false;
                }
            }

            return chars.Count == 0; 
        }

        

        public void Do()
        {
            Console.WriteLine(IsValid("]"));
        }

    }
}

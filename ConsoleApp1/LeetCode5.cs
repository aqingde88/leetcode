using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            List<char> leftCharacters = new List<char> { '(', '[', '{' };
            List<char> rightCharacters = new List<char> { ')', ']', '}' };
            return true;
        }

        

        public void Do()
        {
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    class Methods
    {
        public bool IsValid(string str)
        {
            for(int i = 0;i < str.Length; i++)
            {
                if (!(str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'A' && str[i] <= 'Z'))
                return false;
            }
            return true;
        }
        public int CountChar()
    }
}

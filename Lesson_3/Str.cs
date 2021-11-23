using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    public class Str
    {
        public string newStr (string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
            return new string(charArray);                    
        }       
    }
}

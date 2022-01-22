using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Logger
    {
        public static void Log(ClassDrob num)
        {
            Console.WriteLine($"Целое: {num.Z} Числитель: {num.X}  Знаменатель: {num.Y}");
        }
        public static void Log(bool num)
        {
            Console.WriteLine($"Данное утверждение: {num} ");
        }
        public static void Log(string str)
        {
            Console.WriteLine(str);
        }

    }
}

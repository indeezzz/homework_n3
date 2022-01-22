using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Test
    {
        public static void TestSystem()
        {
            
            ClassDrob A = new ClassDrob(4, 3, 1);
            ClassDrob B = new ClassDrob(3, 4, 0);

            Logger.Log(A + B);

            ClassDrob C = new ClassDrob(4, 3, 0);
            ClassDrob D = new ClassDrob(3, 4, 0);

            Logger.Log(C - D);

            ClassDrob E = new ClassDrob(5, 3, 0);
            ClassDrob F = new ClassDrob(3, 4, 0);

            Logger.Log(E * F);

            ClassDrob G = new ClassDrob(2, 3, 0);
            ClassDrob H = new ClassDrob(3, 4, 0);

            Logger.Log(G / H);

            ClassDrob Z = new ClassDrob(2, 3, 2);

            Logger.Log(Z++);

            ClassDrob X = new ClassDrob(2, 3, 2);

            Logger.Log(X--);

            ClassDrob a = new ClassDrob(5, 3, 0);
            ClassDrob b = new ClassDrob(3, 4, 0);

            Logger.Log(a > b);

            ClassDrob c = new ClassDrob(5, 3, 0);
            ClassDrob d = new ClassDrob(3, 4, 0);

            Logger.Log(c < d);

            ClassDrob e = new ClassDrob(5, 3, 0);
            ClassDrob f = new ClassDrob(5, 3, 0);

            Logger.Log(e <= f);

            ClassDrob h = new ClassDrob(5, 3, 0);
            ClassDrob g = new ClassDrob(3, 4, 0);

            Logger.Log(h >= g);

            ClassDrob x = new ClassDrob(5, 3, 0);
            ClassDrob z = new ClassDrob(5, 3, 0);

            Logger.Log(x == z);

            ClassDrob y = new ClassDrob(5, 3, 0);
            ClassDrob w = new ClassDrob(3, 4, 0);

            Logger.Log(y != w);

            ClassDrob j = new ClassDrob(5, 3, 1);
            ClassDrob k = new ClassDrob(5, 3, 2);

            Logger.Log(Equals(j,k));

            ClassDrob l = new ClassDrob(5, 3, 1);

            Logger.Log(l.ToString());


        }
    }
}

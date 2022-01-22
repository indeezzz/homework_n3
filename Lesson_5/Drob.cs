using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{

    public class ClassDrob
    {
        private int _x, _y, _z;
        public static int common_denominator = 0;
        public static int numerator = 0;
        public static int integer = 0;
        public int X
        {
            get { return _x; }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get { return _y; }
            set
            {
                _y = value;
            }
        }
        public int Z
        {
            get { return _z; }
            set
            {
                _z = value;
            }
        }
        public ClassDrob()
        {
            _x = _y = _z = 1;
        }

        public ClassDrob(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public static int Denominator(ClassDrob x, ClassDrob y)
        {
            if (x.Y == y.Y)
            {
                common_denominator = x.Y;
                return common_denominator;
            }
            else if (x.Y < y.Y)
            {
                if (y.Y % x.Y == 0)
                {
                    common_denominator = y.Y;
                    x.X = x.X * (y.Y / x.Y);
                    return common_denominator;
                }
                else if (x.Y > y.Y)
                {
                    if (x.Y % y.Y == 0)
                    {
                        common_denominator = x.Y;
                        y.X = y.X * (x.Y / y.Y);
                        return common_denominator;
                    }
                }
            }

            common_denominator = x.Y * y.Y;
            x.X = x.X * y.Y;
            y.X = y.X * x.Y;



            return common_denominator;
        }
        public static ClassDrob Integer(ClassDrob x)
        {
            if (x.X > x.Y)
            {
                x.Z = x.X / x.Y;
                x.X = (x.X - (x.Y * x.Z));
                return x;
            }
            else if (x.X == x.Y)
            {
                x.Z = x.X / x.Y;
                x.X = 0;
                x.Y = 0;
            }
            return x;
        }
        public static Tuple<ClassDrob, ClassDrob> ValidInteger(ClassDrob x, ClassDrob y)
        {
            if (x.Z > 0)
            {
                x.X = (x.Z * x.Y) + x.X;
                x.Z -= x.Z;
                Tuple.Create(x, y);
            }
            else if (y.Z > 0)
            {
                y.X = (y.Z * y.Y) + y.X;
                y.Z -= y.Z;
                Tuple.Create(x, y);
            }

            return Tuple.Create(x, y);
        }
        public static ClassDrob ValidInteger(ClassDrob x)
        {
            if (x.Z > 0)
            {
                x.X = (x.Z * x.Y) + x.X;
                x.Z -= x.Z;
                return x;
            }
            return x;

        }
        // Перегружаем бинарный оператор +
        public static ClassDrob operator +(ClassDrob x, ClassDrob y)
        {
            ValidInteger(x, y);
            x.Y = Denominator(x, y);
            x.X = x.X + y.X;
            return Integer(x);
        }
        // Перегружаем бинарный оператор -
        public static ClassDrob operator -(ClassDrob x, ClassDrob y)
        {
            ValidInteger(x, y);
            x.Y = Denominator(x, y);
            x.X = x.X - y.X;
            return Integer(x);
        }
        // Перегружаем бинарный оператор *
        public static ClassDrob operator *(ClassDrob x, ClassDrob y)
        {
            ValidInteger(x, y);
            x.Y = x.Y * y.Y;
            x.X = x.X * y.X;
            return Integer(x);
        }
        // Перегружаем бинарный оператор /
        public static ClassDrob operator /(ClassDrob x, ClassDrob y)
        {
            ValidInteger(x, y);
            x.Y = x.Y * y.X;
            x.X = x.X * y.Y;
            return Integer(x);
        }

        // Перегружаем бинарный оператор --
        public static ClassDrob operator --(ClassDrob x)
        {
            ValidInteger(x);
            x.X -= x.Y;
            Integer(x);
            return x;
        }
        // Перегружаем бинарный оператор ++
        public static ClassDrob operator ++(ClassDrob x)
        {
            ValidInteger(x);
            x.X += x.Y;
            Integer(x);
            return x;
        }

        // Перегружаем бинарный оператор <
        public static bool operator <(ClassDrob x, ClassDrob y)
        {
            ValidInteger(x);
            ValidInteger(y);
            x.Y = Denominator(x, y);
            if (x.X < y.X)
            {
                return true;
            }
            return false;
        }
        // Перегружаем бинарный оператор >
        public static bool operator >(ClassDrob x, ClassDrob y)
        {
            ValidInteger(x);
            ValidInteger(y);
            x.Y = Denominator(x, y);
            if (x.X > y.X)
            {
                return true;
            }
            return false;
        }
        // Перегружаем бинарный оператор <=
        public static bool operator <=(ClassDrob x, ClassDrob y)
        {
            ValidInteger(x);
            ValidInteger(y);
            x.Y = Denominator(x, y);
            if (x.X <= y.X)
            {
                return true;
            }
            return false;
        }
        // Перегружаем бинарный оператор >=
        public static bool operator >=(ClassDrob x, ClassDrob y)
        {
            ValidInteger(x);
            ValidInteger(y);
            x.Y = Denominator(x, y);
            if (x.X >= y.X)
            {
                return true;
            }
            return false;
        }

        // Перегружаем бинарный оператор ==
        public static bool operator ==(ClassDrob x, ClassDrob y)
        {
            ValidInteger(x);
            ValidInteger(y);
            x.Y = Denominator(x, y);
            if (x.X == y.X)
            {
                return true;
            }
            return false;
        }

        // Перегружаем бинарный оператор !=
        public static bool operator !=(ClassDrob x, ClassDrob y)
        {
            return !(x == y);
        }
        // Переопределяем метод Equals
        public override bool Equals(object objA)
        {
            return Equals(objA as ClassDrob);
        }

        public bool Equals(ClassDrob x)
        {
            return 
                   X == x.X &&
                   Y == x.Y &&
                   Z == x.Z;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }

        // Переопределяем метод ToString()
        public override string ToString()
        {
            return $"Целое: {Z} Числитель:  {X} Знаменатель: {Y}";
        }

    }
}


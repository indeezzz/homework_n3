using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Test
    {
        public static void TestSystem()
        {
            Build[] builders = new Build[]
            {
                new Build (100, 3, 6, 72) { },
                new Build (200, 10, 6, 120) { },
            };

            builders[0].GetFullInfo();
            builders[1].GetFullInfo();

            builders[0].GetHeightofHouse();
            builders[1].GetHeightofHouse();

            builders[0].GetAparmentsofFrDoor();
            builders[1].GetAparmentsofFrDoor();
        }
    }
}

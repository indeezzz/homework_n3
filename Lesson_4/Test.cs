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
           
            BuildFactory.CreateFullInfo(BuildFactory.CreateBusinessObject(100, 3, 6, 72));
            BuildFactory.ValidHeightofHouse(BuildFactory.CreateBusinessObject(100, 3, 6, 72));
            BuildFactory.ValidAparmentsofFrDoor(BuildFactory.CreateBusinessObject(100, 3, 6, 72));
            
        }
    }
        
}

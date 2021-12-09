using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    public abstract class BuildFactory : BuildClass
    {
        public static BuildClass CreateBusinessObject(int height, int level, int frdoor, int apartments)
        {
            if (height > 0 && level > 0 && frdoor > 0 && apartments > 0)
            {
                return Construct(height, level, frdoor, apartments);
            }
            return null;
        }
        public static BuildClass CreateFullInfo(BuildClass build)
        {
            if (build != null)
            {
                GetFullInfo(build);
            }
            return null;
        }
        public static void ValidHeightofHouse(BuildClass build)
        {

           if (build != null && build.Height != 0 )
            {
                GetHeightofHouse(build, build.Height);
            }
        }
        public static void ValidAparmentsofFrDoor(BuildClass build)
        {
            if (build != null && build.Apartments != 0 && build.Frdoor != 0 && build.Level != 0)
            {
                GetAparmentsofFrDoor(build, build.Apartments, build.Frdoor, build.Level);
            }
        }
        private BuildFactory()
        {
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    //класс здания
    public class BuildClass
    {
        public Guid Number { get; private set; }
        public int Height { get; set; }
        public int Level { get; set; }
        public int Frdoor { get; set; }
        public int Apartments { get; set; }
        public string MyProperty { get; private set; }

        private BuildClass(int height, int level, int frdoor, int apartments) : this(Guid.Empty, height, level, frdoor, apartments) { }
        private BuildClass(Guid number, int height, int level, int frdoor, int apartments)
        {            
            number = Guid.NewGuid();
            Number = number;
            Height = height;
            Level = level;
            Frdoor = frdoor;
            Apartments = apartments;
        }

        protected BuildClass()
        {
        }

        protected static BuildClass Construct(int height, int level, int frdoor, int apartments)
        {
            return new BuildClass(height, level, frdoor,apartments);
        }

        protected static void GetFullInfo(BuildClass build)
        {
            Logger.Log($"Дом под номером: {build.Number} Высота здания: {build.Height} Этажей: {build.Level} Подъездов: {build.Frdoor} Квартир: {build.Apartments}");
        }
        protected static void GetHeightofHouse(BuildClass build, int height)
        {
            Logger.Log($"Дом под номером: {build.Number} Высота здания: {height} ");
        }
        protected static void GetAparmentsofFrDoor(BuildClass build, int apartments, int frdoor, int level)
        {
            int frdoor_appartment = apartments / frdoor;
            Logger.Log($"Уникальный номер дома:{build.Number} \t Количество квартир в подъезде: {frdoor_appartment} \t Количество квартир на этаже: {frdoor_appartment / level}");
        }
    }
}

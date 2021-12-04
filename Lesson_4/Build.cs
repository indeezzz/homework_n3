using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    public class Build
    {
        private Guid _number;
        private int _height;        
        private int _level;
        private int _frdoor;
        private int _apartments;

        public Build(int height, int level, int frdoor, int apartments) : this(Guid.Empty, height, level, frdoor, apartments) { }
        private Build(Guid number, int height, int level, int frdoor, int apartments)
        {
            number = Guid.NewGuid();
            _number = number;
            _height = height;
            _level = level;
            _frdoor = frdoor;
            _apartments = apartments;
        }
        public void GetFullInfo()
        {
            Console.WriteLine($"Уникальный номер дома:{_number} \n Количество этажей в здании: {_level} \n Высота здания: {_height} \n Количество подъездов: {_frdoor} ");
        }
        public void GetHeightofHouse()
        {
            Console.WriteLine($"Уникальный номер дома:{_number} \n Высота здания: {_height}");
        }
        public void GetAparmentsofFrDoor()
        {
            int frdoor_appartment = _apartments / _frdoor;
            Console.WriteLine($"Уникальный номер дома:{_number} \n Количество квартир в подъезде: {frdoor_appartment} \n Количество квартир на этаже: {frdoor_appartment / _level}");
        }        
    }
}

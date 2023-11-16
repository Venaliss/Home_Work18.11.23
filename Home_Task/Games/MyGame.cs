using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task.Games
{
    class MyGame:IGames
    {
        public void Play()
        {
            Console.WriteLine("Моя Игра!!!");
            Console.WriteLine("Взять ружье в руки");
            Console.WriteLine("Выстрелить");
            Console.WriteLine("Попасть в цель");
        }     
    }
}

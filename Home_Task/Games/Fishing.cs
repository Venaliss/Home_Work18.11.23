using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task.Games
{
    class Fishing:IGames
    {
        public void Play()
        {
            Console.WriteLine("Игра Рыбалка!!!");
            Console.WriteLine("Взять удочку");
            Console.WriteLine("Насодить приманку на удочку");
            Console.WriteLine("Поймать рыбу");
        }
    }
}

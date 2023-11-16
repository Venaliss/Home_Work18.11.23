using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task.Games
{
    class PostMan:IGames
    {
        public void Play()
        {
            Console.WriteLine("Игра Почтальон!!!");
            Console.WriteLine("Принять письма");
            Console.WriteLine("Доставить письма");
        }
    }
}

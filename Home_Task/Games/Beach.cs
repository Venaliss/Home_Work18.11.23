using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task.Games
{
    class Beach : IGames
    {
        public void Play()
        {
            Console.WriteLine("Игра Пляж!!!");
            Console.WriteLine("Выравнивает поверхность для замка");
            Console.WriteLine("Строит большой замок");
        }
    }
}

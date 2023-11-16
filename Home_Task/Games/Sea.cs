using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task.Games
{
    internal class Sea : IGames
    {
        public void Play()
        {
            Console.WriteLine("Игра Море!!!");
            Random rnd = new Random();
            Console.WriteLine("Спрыгнуть с вышки, прямо в воду");
            Console.WriteLine($"Преодолеть {rnd.Next(1, 100)}м в воде");
            Console.WriteLine($"Задержать дыхание на {rnd.Next(1, 10)} минуты");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task.Games
{
    class Mountain: IGames
    {
        public void Play()
        {
            Console.WriteLine("Игра Горка!!!");
            Console.WriteLine("Подниматься на гору");
            Console.WriteLine("Сталкивать всех с горы");
        }
    }
}

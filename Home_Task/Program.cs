using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home_Task.Games;

namespace Home_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            /*В консоли необходимо создать 4 команды: Россия, Франция, Китай и Казахстан, и чтобы они сыграли в 6 игр.*/
            Console.WriteLine("В консоли необходимо создать 4 команды: Россия, Франция, Китай и Казахстан, и чтобы они сыграли в 6 игр.");
            string[] strArr = new string[4] { "Russia", "France", "China", "Kazathstan" };
            for (int i = 0; i <= 3; i++)
            {
                Team team = new Team(strArr[i]);
                team.Games(new Beach());
                team.Games(new MouseHaunt());
                team.Games(new Sea());
                team.Games(new Fishing());
                team.Games(new PostMan());
                team.Games(new Mountain());
                team.Games(new MyGame());
            }
            Console.ReadKey();; 
        }
    }
}

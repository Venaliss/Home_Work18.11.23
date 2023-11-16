using System;


namespace Home_Task.Games
{
    class MouseHaunt: IGames
    {
        public void Play()
        {
            Console.WriteLine("Игра Мышеловка!!!");
            Console.WriteLine("Поставить мышеловку");
            Console.WriteLine("Поймать мышь");
            Console.WriteLine("Отдать ведущему");
        }
    }
}

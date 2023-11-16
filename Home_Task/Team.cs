using System;

namespace Home_Task
{
    class Team
    {
        public string Name { get; set; }

        public Team(string name)
        {
            this.Name = name;
        }

        public void Games(IGames games)
        {
            Console.WriteLine($"\nКоманда {Name} приняла игру:\n");
            games.Play();
        }
    }
}

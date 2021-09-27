using System;

namespace simpleFight2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter hero = new Fighter();
            Fighter enemy = new Fighter();

            hero.Hero();
            enemy.Enemy();





            while (hero.hp > 0 && enemy.hp > 0)
            {
                Console.WriteLine(enemy.name);
                hero.hp -= 22;
            }
        }
    }
}

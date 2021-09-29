using System;

namespace simpleFight2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter hero = new Fighter();
            Fighter enemy = new Fighter();
            Weapon ChooseWeapon = new Weapon();

            hero.Hero();
            enemy.Enemy();
            ChooseWeapon.ChooseWeapon();


            Console.Clear();





            while (hero.hp > 0 && enemy.hp > 0)
            {

                hero.hp -= enemy.damage;

                System.Console.WriteLine($"{enemy.name} slår ett slag på {hero.name} och tappar {enemy.damage} hp och {hero.name} har nu {hero.hp} hp");

                enemy.hp -= hero.damage -= ChooseWeapon.weaponDamage;

                System.Console.WriteLine($"{hero.name} slår ett slag på {enemy.name} och tappar{hero.damage} hp men {hero.name} tar upp sitt vapen och skjuter ett skott som skadar {ChooseWeapon.weaponDamage}hp så nu har {enemy.name} {enemy.hp} hp. ");


                Console.Clear();



                if (enemy.hp < 0)
                {
                    Console.WriteLine("Grattis, du vann!");
                    Console.WriteLine("\nTryck Enter för att gå vidare");

                }

                else if (hero.hp < 0)
                {
                    Console.WriteLine("Du förlorade!");
                    Console.WriteLine("\nTryck Enter för att gå vidare");
                }

                Console.WriteLine("\n ");

                Console.ReadLine();



            }
        }
    }
}

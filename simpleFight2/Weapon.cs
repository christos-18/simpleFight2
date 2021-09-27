using System;

namespace simpleFight2
{
    public class Weapon
    {
        public string weapon;


        Random generator = new Random();

        int weaponDamage = generator.Next(10, 21);
        public Weapon()
        {
            Console.WriteLine("Välj vilket vapen du vill använda: \n \n Alla vapen är olika bra \n \n  weapon 1 = Glock 19 \n  weapon = Sig Sauer P365 \n  weapon 3 = Taurus G2c\n ");


            while (weapon != "weapon 1" && weapon != "weapon 2" && weapon != "weapon 3")

            {

                Console.WriteLine("\n");


                Console.WriteLine("Svara bara (weapon 1), (weapon 2) eller (weapon 3)");

                Console.WriteLine("\n");

                weapon = Console.ReadLine();
            }

            if (weapon == "weapon 1")
            {

            }

            else if (weapon == "weapon 2")
            {

            }

            else if (weapon == "weapon 3")
            {

            }

        }

    }
}


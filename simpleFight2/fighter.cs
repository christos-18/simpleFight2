using System;

namespace simpleFight2
{
    public class Fighter
    {
        public int hp = 100;

        public int damage;
        public string name;

        public void Hero()
        {
            Console.WriteLine("Välj vilken Hero du vill spela: \n \n  Ludde \n  Philip \n  Walter ");

            while (name != "Ludde" && name != "Philip" && name != "Walter")

            {

                Console.WriteLine("\n");

                Console.WriteLine("Svara bara (Ludde), (Philip) eller (Walter)");

                Console.WriteLine("\n");

                name = Console.ReadLine();
            }

            if (name == "Ludde")
            {
                damage = 25;
                hp = 110;
            }

            else if (name == "Philip")
            {
                damage = 30;
            }

            else if (name == "Walter")
            {
                hp = 120;
            }

            Console.Clear();


            Console.WriteLine($"Du kommer nu att spela som {name}");


            Console.WriteLine("\n");


        }

        public void Enemy()
        {
            Console.WriteLine("Välj vilken Enemy du vill möta: \n \n Alla Motståndare är olika svåra \n \n  Enemy 1 \n  Enemy 2 \n  Enemy 3 \n ");


            while (name != "Enemy 1" && name != "Enemy 2" && name != "Enemy 3")

            {

                Console.WriteLine("\n");


                Console.WriteLine("Svara bara (Enemy 1), (Enemy 2) eller (Enemy 3)");

                Console.WriteLine("\n");

                name = Console.ReadLine();
            }

            if (name == "Enemy 1") //beroende på vilken Enemy man möter så är det olika svårt
            {
                hp = 90;
            }

            else if (name == "Enemy 2")
            {
                hp = 150;
            }

            else if (name == "Enemy 3")
            {
                hp = 130;
            }




            Console.WriteLine("\n");

            Console.Clear();


            Console.WriteLine($"Du kommer nu att möta {name}");

        }

        public void fight()
        {
            Console.Clear();

            




        }



    }
}
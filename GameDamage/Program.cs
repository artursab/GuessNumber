

namespace GameDamage
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Random rand = new Random();
            float health1 = rand.Next(90, 100);
            int damage1 = rand.Next(10, 30);
            int armor1 = rand.Next(15, 45);


            float health2 = rand.Next(80, 100);
            int damage2 = rand.Next(15, 50);
            int armor2 = rand.Next(20, 30);

            Console.WriteLine($"Warrior1 - {health1} health, {damage1} damage, {armor1} armor");
            Console.WriteLine($"Warrior2 - {health2} health, {damage2} damage, {armor2} armor");


            while (health1 > 0 && health2 > 0)
            {
                health1 -= Convert.ToSingle(rand.Next(0, damage2 + 1)) / 100 * armor1;
                health2 -= Convert.ToSingle(rand.Next(0, damage1 + 1)) / 100 * armor2;

                Console.WriteLine("Warrior health 1: " + health1);
                Console.WriteLine("Warrior health 2: " + health2);
            }

            if(health1 <= 0 && health2 <= 0)
            {
                Console.WriteLine("Draw!");
            }
            else if(health1 <= 0)
            {
                 
            }

        }
    }

}
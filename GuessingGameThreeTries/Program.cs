using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme kastega numbrit ära arvata;
            //siis mängu võidab arvuti. 
            //*programm genereerib juhuslikku numbrit ühte korda.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;
            while (i<3)
            {
                Console.WriteLine("Sisesta number 1-10:");

                int myRandomNumber = Convert.ToInt32(Console.ReadLine());

                if (myRandomNumber == cpuNumber)
                {
                    Console.WriteLine("You win!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale.{3 - i} katset on jäänud.");
                }
            }
            Console.WriteLine("Arvuti võit");
        }
    }
}

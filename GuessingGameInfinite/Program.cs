using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu. 
            //*programm genereerib juhuslikku numbrit ühte korda. 

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool a = true;

            while (a)
            {
                Console.WriteLine($"Sisesta number 1-10");
                int myRandomNumber = Convert.ToInt32(Console.ReadLine());

                if (myRandomNumber == cpuNumber)
                {
                    Console.WriteLine("Oled võitja!");
                    a = false;
                }
            }
        }
    }
}

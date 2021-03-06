using System;

namespace LoopsAndNumbers1
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-koodi;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemsat!";
            //kui sisestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti";
            //kasutajal on kolm katset. i < 3

            int i = 0; //i-iteration

            while (i < 3) // While-loop
            {
                Console.WriteLine("Sisesta PIN:");

                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemst!");
                    break;
                }
                else
                {
                    // (i = i + 1) == i++
                    i++;
                    Console.WriteLine($"Vale PIN.{3 - i} katset on jäänud.");
                }

            }

            Console.WriteLine("Kena päeva");
        }
    }
}

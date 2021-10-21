using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-koodi;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemsat!";
            //kui sisestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti";
            //kasutajal on kolm katset.

            Console.WriteLine("Sisesta PIN:");
            int userPIN = Convert.ToInt32(Console.ReadLine());

            if(userPIN == 1234)
            {
                Console.WriteLine("Tere tulemst!");

            }
            else
            {
                Console.WriteLine("Vale PIN. Proovi uuesti");

            }
            Console.WriteLine("Kena päeva!");

            


        }
    }
}

﻿using System;

namespace LoopsAndNumbers3
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kui genereeritud number on 5, programm lõpetab oma tööd ja soovib kasutajale "kena päeva";
            //kui genereeritut number on midagi muud, siis programm jätkab oma tööd. 

            Random rnd = new Random();
            int i = 0; 

            while  (i != 5)
            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik number on {myRandomNumber}");
                if (myRandomNumber == 5)
                {
                    i = myRandomNumber;
                }
            }
            

            Console.WriteLine("Kena päeva!");
            
        }
    }
}
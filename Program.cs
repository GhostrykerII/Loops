using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loops");
            Console.WriteLine();


            int[] ammo = new int[5];
            ammo[0] = 6;
            ammo[1] = 2;    
            ammo[2] = 25;    
            ammo[3] = 30;
            ammo[4] = 60;

            //Long Way to do it
            Console.WriteLine(ammo[0]); // access 1 element of an array
            Console.WriteLine(ammo[1]);
            Console.WriteLine(ammo[2]);
            Console.WriteLine(ammo[3]);
            Console.WriteLine(ammo[4]);


            int start = 0;
            int end = 4;
            int i = start; // i = Index

          // Loop
            while(i <= end)
            {
                Console.WriteLine("Weapon #" + i + ": " + ammo[i]); 
                i = i + 1;
            }

           // while (ammo[2] <= end)
            //{
           //     Console.WriteLine(ammo + ", ");
           // }


            //Hard Coded Count

            //count 1-10
           // Console.WriteLine(1);
           // Console.WriteLine(2);
           // Console.WriteLine(3);
           // Console.WriteLine(4);
           // Console.WriteLine(5);
           // Console.WriteLine(6);
           // Console.WriteLine(7);
           // Console.WriteLine(8);
           // Console.WriteLine(9);
           // Console.WriteLine(10);



            Console.ReadKey(true);
        }
    }
}

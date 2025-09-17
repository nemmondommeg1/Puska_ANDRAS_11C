using System.ComponentModel.DataAnnotations;

namespace Puska_ANDRAS_11C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] t = { 1, 2, 3, 4, 5, 6};
            
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write(t[i]);
            }
            Console.WriteLine();
            int j = 0;
            while(j < t.Length)
            {
                Console.WriteLine(t[j]);
                j++;
            }
            //osszegzes
            int s = 0;
            for(int i= 0; i < t.Length; i++)
            {
                s += t[i];
            }
            Console.WriteLine($"Az elemek osszege: {s}");

            
            //megszamlalas
            int db = 0;
            int ptl = 0;
            for(int i = 0; i < t.Length; i++)
            {
                if (t[i] % 2 == 0)
                {
                    db++;
                }
                else
                {
                    ptl++;
                }
            }
            Console.WriteLine($"A paros szamok szama: {db}");
            Console.WriteLine($"A paratlan szamok szama: {ptl}");
            //szelsoertek
            int max = 0;
            for(int i = 0; i < t.Length; i++)
            {
                if (t[i] > max)
                {
                    max = i;
                }
            }
            int min = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] < min)
                {
                    min = i;
                }
            }
            Console.WriteLine($"A listaban a legnagyobb szam: {t[min]}, helye: {min+1}");
            Console.WriteLine();


            //kivalasztas

            int van = 0;
            for(int i = 0; i < t.Length; i++)
            {
                if (t[i] % 2 == 0)
                {
                    van = 1;
                }
            }
            if(van == 1)
            {
                Console.WriteLine("Van paros szam a listaban.");
            }
            else
            {
                Console.WriteLine("Nincs paros szam a listaban.");
            }
            //eldontes
            bool vanE = false;
            for(int i = 0; i < t.Length; i++)
                if (t[i] == 7)
                {
                    vanE = true; 
                }
                if (vanE)
                
                    {
                        Console.WriteLine("Van 7-tel oszthato szam");
                    
                    }
                    else
                    {
                        Console.WriteLine("Nincs 7-tel oszthato szam");
                    }

            //kereses

            int keresett = 3;
            /* a 3-as sazmot keresem a listaban*/
            int hely = 0;
            /*Ez a listaban a 3-as szam helye (ha van)*/
            for (int i = 0; i < t.Length; i++)
                if (t[i] == keresett)
                {
                    hely += i+1;
                }

            if( hely == 3)
            {
                Console.WriteLine($"A listaban van 3-as, helye: {hely}"); 
            
            }
            else
            {
                Console.WriteLine($"A listaban nincs 3-as");
            }


            Console.WriteLine("Hello, World!");
        }
    }
}

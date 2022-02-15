using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace area
{
    class program
    {
        static void Main(string[] args)
        {

            float area = 0;
            float apotema = 0;
            float perimetro = 0;


            Console.WriteLine("Escriba el perimetro del hexagono  ");
            perimetro = float.Parse(System.Console.ReadLine());
            Console.WriteLine("Escriba el apotema del hexagono  ");
            apotema = float.Parse(System.Console.ReadLine());
            area = ((perimetro * 6) * (apotema)) / 2;
            Console.WriteLine("El resultado del area es {0}", area);


        }



    }


}


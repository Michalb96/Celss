using System;

namespace Automaty_Komórkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[,] x= new string[10,10];

            for(int i = 0 ;i<10; i++)
            {
                for(int j=0; j<10 ; j++)
                {
                    x[i,j]="*";
                    //Console.WriteLine("*");
                }
            }
            for(int i = 0 ;i<10; i++)
            {
                Console.WriteLine();
                for(int j=0; j<10 ; j++)
                {
                    Console.Write(x[i,j]);
                }
            }
            /****************TESTY****************** */
            Neighbourhood1D nowy = new Neighbourhood1D(20,0);
            int boardlength = 10;
           //int z =nowy.mirrorX(boardlength);
            Console.WriteLine(boardlength);
            Cords1D cord = nowy.GetCoordinates(boardlength);
 
        }
    }
}

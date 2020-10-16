using System;

namespace Pract03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < Znach.OtstSv; i++)
                Console.WriteLine("");

            for (int i = 0; i < Znach.VisPol; i++)
            {
                

                if (i == 0)
                    Nach();
                else
                    NachBol1();

                SrCh();

                if (i == Znach.VisPol - 1)
                    Kon();
            }

        }

        static void Nach()
        {
            for (int n = 0; n < Znach.OtstSlv; n++)
                Console.Write(" ");

            Console.Write('┌');
            for (int i = 0; i < Znach.ShirCh; i++)
                Console.Write('─');
            for (int t = 0; t < Znach.ShirPol -1; t++)
            {
                Console.Write('┬');
                for (int i = 0; i < Znach.ShirCh; i++)
                    Console.Write('─');
            }
                
            Console.WriteLine('┐');
        }

        static void NachBol1()
        {
            for (int n = 0; n < Znach.OtstSlv; n++)
                Console.Write(" ");

            Console.Write('├');
            for (int i = 0; i < Znach.ShirCh; i++)
                Console.Write('─');
            for (int t = 0; t < Znach.ShirPol -1; t++)
            {
                Console.Write('┼');
                for (int i = 0; i < Znach.ShirCh; i++)
                    Console.Write('─');
            }
                
            Console.WriteLine('┤');
        }

        static void Kon()
        {
            for (int n = 0; n < Znach.OtstSlv; n++)
                Console.Write(" ");

            Console.Write('└');
            for (int i = 0; i < Znach.ShirCh; i++)
                Console.Write('─');
            for (int t = 0; t < Znach.ShirPol -1; t++)
            {
                Console.Write('┴');
                for (int i = 0; i < Znach.ShirCh; i++)
                    Console.Write('─');
            }
                
            Console.WriteLine('┘');
         }

        static void SrCh()
        {
       
            for (int N = 0; N < Znach.VisCh; N++)
            {
                for (int n = 0; n < Znach.OtstSlv; n++)
                    Console.Write(" ");

                Console.Write('│');
                for (int i = 0; i < Znach.ShirCh; i++)
                    Console.Write(' ');
                for (int t = 0; t < Znach.ShirPol -1; t++)
                {
                    Console.Write('│');
                    for (int i = 0; i < Znach.ShirCh; i++)
                        Console.Write(' ');
                }
                    
                Console.WriteLine('│');
            }
        }
    }

    class Znach
    {

        public const int VisPol = 2;
        public const int ShirPol = 3;
        public const int VisCh = 2;
        public const int ShirCh = 5;
        public const int OtstSv = 6;
        public const int OtstSlv = 4;
    }

    
}

using System;

namespace Inlämningsuppgifterkapitel6._3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj en");
            Console.WriteLine("1. Addera tre tal");
            Console.WriteLine("2. Största talet av två tal");
            Console.WriteLine("3. Avsluta programet");
            int val = int.Parse(Console.ReadLine());

            switch (val)
            {
                case 1:
                    MenyvalAddera();
                    break;

                case 2:
                    MenyvalStörstaTalet();
                    break;

                case 3:
                    break;

                default:
                    Console.WriteLine("ogiltig svar");
                    break;
            }
        }

        static void MenyvalAddera()
        {
            Console.WriteLine("Skriv ett tal");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("skriv ett till tal");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ännu ett till tal");
            int tal3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Summan blir = " + (tal1 + tal2 + tal3));
        }

        static void MenyvalStörstaTalet()
        {
            Console.WriteLine("Skriv in ett tal");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ännu ett till tal");
            int tal2 = int.Parse(Console.ReadLine());
            if (tal2 > tal2)
            {
                Console.WriteLine("Största talet blir" + tal1);
            }

            else if (tal1 < tal2)
            {
                Console.WriteLine("Största talet blir" + tal2);
            }

            else
            {
                Console.WriteLine("Talen är lika stora");
            }
        }
    }
}
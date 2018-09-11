using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BerättlsenOmIngenting
{
    public class Berättelsen
    {
        public string svarNamn;
        public string favoritFärg;
        public string favoritMat;
        public int ålder;
        public bool ålderMedSiffror;



        public void FragaAnvandare()
        {
            
            Console.Write("Vad heter du? : ");
            svarNamn = Console.ReadLine();
            while (ålderMedSiffror == false)
            {
                Console.Write("Hur gammal är du? : ");
                ålderMedSiffror = int.TryParse(Console.ReadLine(), out ålder);
            }

            Console.Write("Vilken är din favoritfärg? : ");
            favoritFärg = Console.ReadLine();

            Console.Write("Vad gillar du för mat? : ");
            favoritMat = Console.ReadLine();
        }

        public void Beratta()
        {
            Console.WriteLine();
            Console.WriteLine($"Det var en gång en katt som hette {svarNamn}.");
            Console.WriteLine($"Katten är precis som du, {ålder} år gammal.");
            Console.WriteLine($"Kattens favoritfärg är också {favoritFärg}.");
            Console.WriteLine($"Katten gillar att äta {favoritMat}, för det är kattmat.");
            Console.WriteLine("");
        }

    }
}

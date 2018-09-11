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
        public string favoritmat;




        public void FragaAnvandare()
        {
            Console.WriteLine("Vad heter du?");
            svarNamn = Console.ReadLine();

            Console.WriteLine("Vilken är din favoritfärg?");
            favoritFärg = Console.ReadLine();

            Console.WriteLine("Vad gillar du för mat?");
            favoritmat = Console.ReadLine();
        }

        public void Beratta()
        {
            Console.WriteLine();
            Console.WriteLine($"Det var en gång en katt som hette {svarNamn}");
            Console.WriteLine($"Kattens favoritfärg är {favoritFärg}");
            Console.WriteLine($"Katten gillar också att äta{favoritmat}");
            Console.WriteLine("");
        }

    }
}

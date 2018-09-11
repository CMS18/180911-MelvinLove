using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace BerättlsenOmIngenting
{
    class Program
    {
        public static void Main(string[] args)
        {
            Berättelsen story = new Berättelsen();
            story.FragaAnvandare();
            story.Beratta();

            Console.ReadLine();



        }
    }
}

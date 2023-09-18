using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploHeranca_1.classe_2
{
    internal class Gato:Mamifero
    {
        public string CorOlhos { get; set; }

        public override void Barulho()
        {
            Console.WriteLine("Miauu!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploHeranca_1.classe_2
{
    internal class Mamifero
    {
        public DateOnly Datanascimento {  get; set; }
        public string Raca {  get; set; }

        public Mamifero(DateOnly dataNasc, string raca)
        {
           Datanascimento = dataNasc;
            Raca = raca;
        }
        public Mamifero()
        {

        }
        public virtual void Barulho ()
        {
            Console.WriteLine(this.Raca + " fazendo barulho");
        }
    }
}

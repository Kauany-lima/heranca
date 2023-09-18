using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploHeranca_1.classe_2
{
    internal class Cachorro:Mamifero
    {
        public double Peso { get; set; }

        public Cachorro(double peso, string raca, DateOnly dataNasc) :base(dataNasc, raca)
        {
          Peso = peso;
        } 
        public Cachorro()
        {

        }
        public override void Barulho()
        {
            Console.WriteLine("Auau!");
        }

    }
}

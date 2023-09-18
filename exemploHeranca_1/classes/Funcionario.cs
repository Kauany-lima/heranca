using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploHeranca_1.classes
{
    internal class Funcionario:Pessoa //Funcionário é do tipo pessoa
    {
        public double Salario { get; set; }
        public string SIAP { get; set; }
        public int CargaHoraria { get; set; }   
    }
}

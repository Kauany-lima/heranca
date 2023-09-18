using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHernca_2.Classes
{
    internal class ContaEstudante: Conta
    {
       public string CPF { get; set; }
        public string NomeInstituicao { get; set; }
        public double LImiteCheque { get; set; }

        public ContaEstudante(string cpf, string nomeInstituicao, double lImiteCheque)
        {
            CPF = cpf;
            NomeInstituicao = nomeInstituicao;
            LImiteCheque = lImiteCheque;
        }

        public ContaEstudante()
        {
        }

        public void Sacar()
        {

        }
       

    }
}

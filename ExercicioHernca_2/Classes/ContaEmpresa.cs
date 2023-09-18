using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHernca_2.Classes
{
    internal class ContaEmpresa: Conta
    {
        public double Anuidade { get; set; }
        public double LimiteEmprestimo { get; set; }
        public double TotalEmprestimo { get; set; }

        public void FazerEmprestimo (double valor)
        {
            Anuidade = 5;   
            LimiteEmprestimo = Saldo;
            TotalEmprestimo = 0;


            if (valor > LimiteEmprestimo)
            {
                Console.WriteLine("Não há saldo suficiente");
            }

            else
            {
                if(valor <= 5000)
                {
                    LimiteEmprestimo = LimiteEmprestimo - valor;
                    TotalEmprestimo = valor + Saldo;

                    Console.WriteLine("Empréstimo realizado!");
                }

                else
                {
                    LimiteEmprestimo = (LimiteEmprestimo - valor) - Anuidade;
                    TotalEmprestimo = valor + Saldo;

                    Console.WriteLine("Empréstimo realizado!\n" + "obs: devido a regulamentação do sistema" +
                       " foi retirado mais 5 reais de taxa do seu limite");
                }
            }
        }

        public override void Sacar(double valor)
        {
            base.Sacar(valor);
        }
    }
}

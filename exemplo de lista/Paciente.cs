﻿
namespace exemplo_de_lista
{
    public class Paciente
    {
        public int Id_paciente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime DataNac { get; set; }

        public Paciente(int id_paciente, string nome, string cpf, string email, DateTime dataNac)
        {
            this.Id_paciente = id_paciente;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.DataNac = dataNac;
        }
    }
}

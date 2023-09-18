using exemploHeranca_1.classe_2;
using exemploHeranca_1.classes; //importando todas as classes 

public class Program
{
    static void Main(string[] args)
    {
        Aluno a = new Aluno();
        a.Cpf = "000";
        a.Nome = "Kauany";

        Funcionario F = new Funcionario();
        F.Cpf = "001";
        F.Nome = "Elias";

        Gato g = new Gato();
        g.Raca = "Siames";
        g.Barulho();
        g.Datanascimento = DateOnly.Parse("11/09/2022");
        g.CorOlhos = "Verde";
        

        Cachorro c = new Cachorro();
        c.Raca = "Vira_lata";
        c.Barulho();
        c.Datanascimento = DateOnly.Parse("11/09/2023");
        c.Peso = 5;
    } 
}
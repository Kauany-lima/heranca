using exemplo_de_lista;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class program
{
    static void Main(string[] args)
    {


        ExemploListaObjeto();
    }
    static void ExemploListaObjeto()
    {
        Paciente p1 = new Paciente(1, "Kauany", "000", "kauany@", new DateTime(2006, 08, 05));
        Paciente p2 = new Paciente(2, "Emanuelly", "300", "emanuelly@", new DateTime(2006, 05, 18));
        Paciente p3 = new Paciente(3, "Claudia", "200000", "claudia@", new DateTime(2006, 08, 05));
        Paciente p4 = new Paciente(4, "Taynara", "000000", "Taynara@", new DateTime(2006, 04, 05));
        Paciente p5 = new Paciente(5, "Elias", "05000000", "antonio@", new DateTime(1986, 09, 26));

        List<Paciente> listapaciente = new List<Paciente>();
        listapaciente.Add(p1);
        listapaciente.Add(p2);
        listapaciente.Add(p3);
        listapaciente.Add(p4);
        listapaciente.Add(p5);

        //O método orderBy ordena uma lista a partir de um determinado atributo
        // esse método retorna uma lista ordenada (precisaa armazer esse resultado)
        //ToList() converte o resultado para uma lista 
        //caso queira apresentar a nova lista ordenada, somente percorre-lá
        //No exemplo, x.nome especifica que irá ordenar pelo atributo nome,
        //pode ser qualquer atributo do objeto

        //List<Paciente> pOrdenados = listapaciente.OrderBy(x => x.Nome).ToList();// ordena pelo atributo que deseja 
        // List<Paciente> pOrdenadosD = listapaciente.OrderByDescending(x => x.Nome).ToList(); //ordena de forma decrescente o atributo desejado
        /*Recupera determinando elemento que contem o valor passado na expressão.
        //No exemplo, recupera o paciente que contém o cpf 000.
       // Paciente pCpf0 = listapaciente.Single(x => x.Cpf == "3333"); quando executar vai dá erro de cara
        Paciente pCpf0 = listapaciente.SingleOrDefault(x => x.Cpf == "3333"); //executa porem retorna um valor nulo

        if (pCpf0 != null)
        {
            Console.WriteLine(pCpf0.Nome);
        }

        else
        {
            Console.WriteLine("Paciente não encontrado");
        }
        */
        string nomeBusca = Console.ReadLine();
        List<Paciente> busca = listapaciente.Where(x => x.Id_paciente > 2 || x.Nome.ToUpper() == nomeBusca.ToUpper()).ToList();// o méodo where é utilizado para selecionar todos que atende alguma expressão
        
        //buscar todos os nomes que inicia com determinada letra
        List<Paciente> buscaL = listapaciente.Where(x => x.Nome.ToUpper().StartsWith("A")).ToList();
        // no exemplo abaixo, seleciona e armazena na lista busca todos os pacientes que possuem
        // o valor de Id_paciente == 1
        foreach (Paciente p in busca)
        {
            Console.WriteLine(p.Nome + " " + p.Cpf + " " + p.Email);
            
        }

    }

    static void Exemplo1()
    {
        List<string> list = new List<string>();
        list.Add("kauany");// adicionando o elemento na lista  denominada list
        list.Add("claudia");
        list.Sort(); //comando responsável por ordenar a lista

        // list.Remove("kauany");// remove pelo nome do elemento
        //list.RemoveAt(0);// remove pela posição do elemento
        //list.Clear(); limpa toda a lista

        List<int> list2 = new List<int>();
        list2.Add(1);// adicionando o elemento na lista denominada list2
        list2.Insert(0, 2);// adicionar um elemento em uma posição especifica da lista 

        // List<int> listadecres = list2.OrderDescending().ToList();
        foreach (int i in list2)// percorre todos os elementos da lista, da primeira posição até a ultima 
        {                         // para cada repetição, copia o endereço da posição atual da lista
                                  // ou seja, na primeira repetição a variável s recebe o valor da posição 0 da lista (Elias)
                                  // na segunda repetição, s recebe o valor da posição 1 da lista (kauany)
            Console.WriteLine(i);
        }


        /*
         * list.count retorna o tamanho da lista
        for(int i = 0; i < list2.Count; i++)
        {
            Console.WriteLine(list2[i]);    
        }
        */
        List<string> listab = new List<string> { "maria b", "maria c" };
        list.AddRange(listab);//


        List<double> listadouble = new List<double> { 2.5, 3, 8.2 }; //iniciando lista com elementos
        listadouble.Add(1);

        bool contem = list.Contains("Kauany");
        Console.WriteLine(contem);
    }
}
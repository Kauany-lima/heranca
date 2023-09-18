using ExercicioHernca_2.Classes;

static void Main(string[] args)
{
    //Instanciando a classe conta
    Conta conta1 = new Conta();

    Console.WriteLine("Digite o nome da agência: ");
    conta1.Agencia = Console.ReadLine();

    Console.WriteLine("Digite o número da conta:");
    Console.WriteLine( conta1.NumeroConta = Console.ReadLine());

    Console.WriteLine("Digite o título da conta:");
    Console.WriteLine(conta1.Titulo = Console.ReadLine());

    Console.WriteLine("Digite o saldo da conta");
    Console.WriteLine(conta1.Saldo = Convert.ToDouble(Console.ReadLine()));


    conta1.Sacar(Convert.ToDouble(Console.ReadLine()));
    conta1.Depositar(Convert.ToDouble(Console.ReadLine()));

    //Instanciando a classe conta estudante
    ContaEstudante contaEstudante = new ContaEstudante();
    Console.WriteLine("Digite seu CPF:");
    Console.WriteLine(contaEstudante.CPF = Console.ReadLine());

    Console.WriteLine("Digite o nome da instituição:");
    Console.WriteLine(contaEstudante.NomeInstituicao = Console.ReadLine());

    Console.WriteLine("Digite seu limite cheque:");
    Console.WriteLine(contaEstudante.LImiteCheque = Convert.ToDouble(Console.ReadLine()));

    contaEstudante.Sacar(Convert.ToDouble(Console.ReadLine()));

    //Instanciando a classe conta empresa
    ContaEmpresa contaEmpresa = new ContaEmpresa();
    contaEmpresa.FazerEmprestimo(Convert.ToDouble(Console.ReadLine()));
    contaEmpresa.Sacar(Convert.ToDouble(Console.ReadLine()));
}
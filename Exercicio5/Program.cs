using Exercicio5;
using System.ComponentModel.Design;

class Program 
{
    static void Main() 
    {
        Console.WriteLine("Olá, tudo bem? Seja bem vindo ao exercicio 5.");
        Menu();
    }

    private static void Menu()
    {
        
        Aluno aluno = new Aluno();
        Console.WriteLine("Qual o nome do aluno?");
        aluno.Name = Console.ReadLine();
        aluno.Materia = verificarMateria();
        MostrarInformacoes(aluno);
    }

    private static void MostrarInformacoes(Aluno aluno)
    {
        string operador = "";
        int count = 0;
        Console.Clear();
        for (int i = 0; i == count; i++)
        {
            Console.WriteLine($"A media da materia {aluno.Materia[i].Nome} do aluno {aluno.Name}, é igual á {aluno.Materia[count].resultado()}.");
        }
        Console.WriteLine($"Você deseja fazer uma nova verificacão?\n1-Sim, desejo fazer de um novo aluno.\n2-Sim, desejo fazer a verificacao de uma nova materia.\n0-Não, desejo sair da aplicacão.");
        operador = Console.ReadLine();
        switch (operador)
        {
            case "1":
                Console.Clear();
                Menu();
                break;
            case "2":
                count = count + 1;
                Console.Clear();
                aluno.Materia = verificarMateria();
                MostrarInformacoes(aluno);
                break;
            case "0":
                Console.Clear();
                Console.WriteLine("Obrigado por utilizar!");
                Environment.Exit(0);
                break;
            default:
                Console.Clear();
                Console.WriteLine("A opcão digitada, não condiz com nenhuma das opcões, retorne novamente para digitar as informacões necessárias, aperte qualquer tecla para prosseguir ");
                Console.ReadKey(true);
                Menu();
                break;


        }
    }

    public static List<Materia> verificarMateria()
    {
        List<Materia> materias = new List<Materia>();
        Materia materia = new Materia();
        Console.WriteLine("Qual o nome da Materia do aluno?");
        materia.Nome = Console.ReadLine();
        Console.WriteLine("Digite a primeira nota:");
        materia.Primeira_nota = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota:");
        materia.Segunda_nota = float.Parse(Console.ReadLine());
        materias.Add(materia);
        return materias;
    }
}
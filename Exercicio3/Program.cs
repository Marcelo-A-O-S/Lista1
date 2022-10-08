using Exercicio3;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

class Program 
{
    static void Main() 
    {
        Console.WriteLine("Olá, tudo bem? Seja bem vindo ao exercicio 3.");
        Menu();
    }


    private static void Menu()
    {
        Funcionario funcionario = new Funcionario();
        Console.WriteLine("Qual o nome do funcionário?");
        string? nome = Console.ReadLine();
        Console.WriteLine("Qual o salario do funcionário?");
        string? salario = Console.ReadLine();
        Verificacao(nome, salario);
        funcionario.nome = nome;
        funcionario.salario = float.Parse(salario);
        Console.WriteLine($"O funcionário {funcionario.nome} tem um salário de R${funcionario.salario} em " + DateTime.Now + " ");



    }

    private static void Verificacao(string nome, string salario)
    {
        string numeros = "0123456789";
        string[] numeradores = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        if (nome == "" || salario == "")
        {
            Console.Clear();
            Console.WriteLine("Nenhum dado foi informado!\nAperte qualquer tecla para ir ao questionario e corrigir as informacões");
            Console.ReadKey(true);
            Console.Clear();
            Menu();
        }
        if (String.Compare(nome, alfabeto.ToLower()) == 1)
        {
            if (String.Compare(salario, numeros) == 1)
            {
                Console.Clear();
                return;

            }
        }

        if(String.Compare(salario, numeros) != 1) 
        {
            Console.Clear();
            Console.WriteLine("O salário informado contém caracteres incorretos\nAperte qualquer tecla para ir ao questionario e corrigir as informacões");
            Console.ReadKey(true);
            Console.Clear();
            Menu();
        }
        if(String.Compare(nome,alfabeto.ToLower()) != 1) 
        {
            Console.Clear();
            Console.WriteLine("O nome informado contém caracteres incorretos\nAperte qualquer tecla para ir ao questionario e corrigir as informacões");
            Console.ReadKey(true);
            Console.Clear();
            Menu();
        }
       

    }
}
using Exercicio4;
using System.ComponentModel.Design;
using System.Data;

class Program
{
    static void Main() 
    {
        Console.WriteLine("Olá, tudo bem? Seja bem vindo ao exercicio 4.");
        Menu();
    }

    private static void Menu()
    {
        parcelasDaOperacao parcela = new parcelasDaOperacao();
        Console.WriteLine("Digite o primeiro numero para prosseguir:");
        string primeiro_numero = Console.ReadLine();
        Console.WriteLine("Digite o segundo numero:");
        string segundo_numero = Console.ReadLine();
        Verificacao(primeiro_numero, segundo_numero);
        parcela.primeironumero = float.Parse(primeiro_numero);
        parcela.segundonumero = float.Parse(segundo_numero);
        Console.WriteLine($"A soma entre {parcela.primeironumero} e {parcela.segundonumero} é igual a {parcela.resultado(parcela)}");
        Fechar();
    }

    private static void Fechar()
    {
        string operador = "";
        Console.WriteLine("Deseja fazer uma nova operacão? \n1- Sim\n2-Não, desejo sair da aplicacão");
        operador = Console.ReadLine();
        switch (operador)
        {
            case "1":
                Console.Clear();
                Menu();
                break;
            case "2":
                Console.Clear();
                Environment.Exit(0);
                break;
            default:
                Console.Clear();
                Console.WriteLine("O que foi digitado não condiz com nenhuma opcão de escolha, aperte qualquer tecla para retornar a opcão de escolha!");
                Console.ReadKey();
                break;
        }

    }

    private static void Verificacao(string primeiro_numero, string segundo_numero)
    {
        string numeros = "0123456789";
        if ( primeiro_numero == "" || segundo_numero == "")
        {
            Console.Clear();
            Console.WriteLine("Nenhum dado foi informado!\nAperte qualquer tecla para retornar e atribuir novos valores");
            Console.ReadKey(true);
            Console.Clear();
            Menu();
        }
        if(String.Compare(primeiro_numero, numeros) != 1) 
        {
            Console.Clear();
            Console.WriteLine("Valores incorretos!\nAperte qualquer tecla para retornar e atribuir novos valores");
            Console.ReadKey(true);
            Console.Clear();
            Menu();
        }
        if(String.Compare(segundo_numero, numeros)!= 1) 
        {
            Console.Clear();
            Console.WriteLine("Valores incorretos!\nAperte qualquer tecla para retornar e atribuir novos valores");
            Console.ReadKey(true);
            Console.Clear();
            Menu();

        }
        if(String.Compare(primeiro_numero, numeros ) == 1) 
        {
            if(string.Compare(segundo_numero, numeros) == 1) 
            {
                return;
            }
        }
    }
}
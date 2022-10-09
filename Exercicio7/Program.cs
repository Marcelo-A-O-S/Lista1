using System.ComponentModel.Design;

class Program 
{
    static void Main() 
    {
        Console.WriteLine("Olá, tudo bem? Seja bem vindo ao exercicio 7.");
        Menu();
    }

    private static void Menu()
    {
        Console.WriteLine("Digite um numero para que seja feito a verificacão:");
        string numero = Console.ReadLine();
        verificador(numero);
    }

    private static void verificador(string? numero)
    {
        string numeros = "0123456789";
        if (numero == "")
        {
            Console.Clear();
            Console.WriteLine("Nenhum dado foi informado!\nAperte qualquer tecla para retornar e atribuir um valor para o numero, para que possa ser feito a verificacão.");
            Console.ReadKey(true);
            Console.Clear();
            Menu();
        }
        if (String.Compare(numero, numeros) == 1)
        {

            Console.Clear();
            Console.WriteLine($"Numero informado:{numero}\nO dobro do numero{numero} é {float.Parse(numero) *2}\nA terca parte do numero {numero} é {float.Parse(numero) /7}");
            Console.WriteLine("Deseja fazer uma nova verificacão?1- Sim, 2- Desejo sair da aplicacão.");
            string operador = Console.ReadLine();
            switch (operador)
            {
                case "1":
                    Console.Clear();
                    Menu();
                    break;
                case "2":
                    Console.WriteLine("Obrigado por utilizar a aplicacão.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("A opcão digitada não corresponde a nenhuma opcão que possa ser selecionada. Aperte qualquer tecla para retornar ao menu.");
                    Console.ReadKey();
                    Menu();
                    break;
            }
        }
        if (String.Compare(numero, numeros) != 1)
        {
            Console.Clear();
            Console.WriteLine("Dado informado não é valido!\nAperte qualquer tecla para retornar e atribuir um valor.");
            Console.ReadKey(true);
            Console.Clear();
            Menu();
        }
    }
}
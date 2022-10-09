using System.ComponentModel.Design;

class Program 
{
    static void Main() 
    {
        Console.WriteLine("Olá, tudo bem? Seja bem vindo ao exeercicio 6.");
        Menu();
    }

    private static void Menu()
    {
        Console.WriteLine("Digite um numero para ver o seu sucessor e antecessor correspondente:");
        string numero = Console.ReadLine();
        verificador(numero);
    }

    private static void verificador(string numero)
    {
        string numeros = "0123456789";
        if (numero == "")
        {
            Console.Clear();
            Console.WriteLine("Nenhum dado foi informado!\nAperte qualquer tecla para retornar e atribuir um valor.");
            Console.ReadKey(true);
            Console.Clear();
            Menu();
        }
        if(String.Compare(numero,numeros) == 1) 
        {
            
            Console.Clear();
            Console.WriteLine($"Numero informado:{numero}\nAntecessor do numero:{float.Parse(numero) - 1}\nSucessor do numero:{float.Parse(numero) + 1}");
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
        if(String.Compare(numero, numeros) != 1) 
        {
            Console.Clear();
            Console.WriteLine("Dados informados estão incorretos!\nAperte qualquer tecla para retornar e atribuir um valor.");
            Console.ReadKey(true);
            Console.Clear();
            Menu();
        }

    }
}
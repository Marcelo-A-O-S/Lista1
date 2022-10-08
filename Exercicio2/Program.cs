// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

class Program 
{
   static void Main() 
   {
        Console.WriteLine("Olá,tudo bem? Seja bem vindo ao exercicio 2.");
        Menu();
   }

    private static void Menu()
    {
        string nome;
        Console.WriteLine("Qual o seu nome?");
        nome = Console.ReadLine();
        //Metodo de verificacao do que foi atribuido a variavel
        Verificacao(nome);
    }

    private static void Verificacao(string nome)
    {
        string[] numeradores = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        foreach (var numero in numeradores)
        {
            //Aqui nessa condicao ele confirma se a variavel nome contem numeros contidos como string
            if (nome.Contains(numero))
            {
                //Se o primeiro if for confirmado, ele vai fazer mais uma verificacao convertendo o numero, se ele voltar true, ele segui e printa a parte a seguir chamando o metodo novamente para que o usuario possa fazer a correcao
                if (int.Parse(nome) >= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Você digitou numeros como nome, e o sistema não reconhece como um nome valido.\nPressione qualquer tecla para poder digitar o seu nome novamente!");
                    Console.ReadKey();
                    Menu();
                }
            }
            //Aqui ele vai fazer a comparacao da variavel nome com a variavel alfabeto, se conter alguma letra semelhante, ele retorna o print a seguir encerrando a aplicacao
            else if (String.Compare(nome, alfabeto.ToLower()) == 1)
            {
                Console.WriteLine($"Olá {nome}, é um prazer te conhecer!");
                Environment.Exit(0);

            }

        }
    }
}

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
        //Metodo para verificar se os dados foram passados corretamente
        Verificacao(nome, salario);
        //Apos a verificacão, se as informacões passarem, é atribuido as informacões as variaveis 
        funcionario.nome = nome;
        funcionario.salario = float.Parse(salario);
        Console.WriteLine($"O funcionário {funcionario.nome} tem um salário de R${funcionario.salario} em " + DateTime.Now + " ");



    }

    private static void Verificacao(string nome, string salario)
    {
        string numeros = "0123456789";
        string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //Aqui ele confirma se não foi passada  nenhuma informacão
        if (nome == "" || salario == "")
        {
            Console.Clear();
            Console.WriteLine("Nenhum dado foi informado!\nAperte qualquer tecla para ir ao questionario e corrigir as informacões");
            Console.ReadKey(true);
            Console.Clear();
            Menu();
        }
        //Aqui ele faz a comparacao do nome com a variavel alfabeto para confirma se existe letras nessa variavel
        if (String.Compare(nome, alfabeto.ToLower()) == 1)
        {
            //Aqui ele confirma se foi atribuido numeros para variavel salario  
            if (String.Compare(salario, numeros) == 1)
            {
                Console.Clear();
                return;

            }
        }
        //Aqui caso se tiver sido atribuido algo que não condiz com que esperamos na variavel salario, ele retorna uma mensagem de erro
        if(String.Compare(salario, numeros) != 1) 
        {
            Console.Clear();
            Console.WriteLine("O salário informado contém caracteres incorretos\nAperte qualquer tecla para ir ao questionario e corrigir as informacões");
            Console.ReadKey(true);
            Console.Clear();
            Menu();
        }
        //Aqui caso se tiver sido atribuido algo que não condiz com que esperamos na variavel nome, ele retorna uma mensagem de erro
        if (String.Compare(nome,alfabeto.ToLower()) != 1) 
        {
            Console.Clear();
            Console.WriteLine("O nome informado contém caracteres incorretos\nAperte qualquer tecla para ir ao questionario e corrigir as informacões");
            Console.ReadKey(true);
            Console.Clear();
            Menu();
        }
       

    }
}
//Nome: Carlos Henrique Alves Santos
//Nome: Nícolas Henrique de Lima Silva

/* Criar um programa que funcione de acordo com o menu
a seguir, sabendo-se que os vetorestêm dimensão 10. Os
itens 1, 2, 3, 4 e 5 são funções.
MENU VETOR - FUNÇÃO
1. Entrada de dados para o vetorA
2. Entrada de dados para o vetorB
3. Imprime os vetores > 0 do vetorA
4. Imprime a soma dos vetores A e B
5. Imprime a soma dos números ímpares > 2 do vetorB
ESCOLHA A SUA OPÇÃO: */

using System.Runtime.Serialization;


//Menu
static void menu()
{

    int[] a = new int[10];
    int[] b = new int[10];
    Console.WriteLine();
    Console.WriteLine("MENU VETOR - FUNÇÃO");
    Console.WriteLine("1. Entrada de dados para o vetorA");
    Console.WriteLine("2. Entrada de dados para o vetorB");
    Console.WriteLine("3. Imprime os vetores > 0 do vetorA");
    Console.WriteLine("4. Imprime a soma dos vetores A e B");
    Console.WriteLine("5. Imprime a soma dos números ímpares > 2 do vetorB");
    Console.WriteLine("ESCOLHA A SUA OPÇÃO: ");

    string opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            funcao1(a);
            break;

        case "2":
            funcao2(b);
            break;

        case "3":
            funcao3(a);
            break;

        case "4":
            funcao4(a, b);
            break;

        case "5":
            funcao5(b);
            break;

        default:
            Console.WriteLine("Informe um valor entre 1 e 5");
            break;

    }
}

//Função 1
static void funcao1(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write("Informe um valor para o vetor A:");
        a[i] = Convert.ToInt32(Console.ReadLine()); 
    }
    menu();
}

//Função 2
static void funcao2(int[] b)
{
    for (int i = 0; i < b.Length; i++)
    {
        Console.Write("Informe um valor para o vetor B:");
        b[i] = Convert.ToInt32(Console.ReadLine());
    }
    menu();
}

//Função 3
static void funcao3(int[] a)
{
    int i;
    Console.WriteLine("Imprimindo valores do vetor A maiores que 0:");
    for (i = 0; i<a.Length; i++)
    {
        if (a[i] >0)
            Console.Write(a[i] + ". ");
    }

    Console.WriteLine();
    menu();
}

static void funcao4(int[] a, int[] b)
{
    int soma = 0;
    Console.WriteLine("Imprimindo a soma dos valores dos vetores A com B:");
    for (int i = 0; i < a.Length; i++)
    {
        soma += a[i];
    }
    Console.WriteLine(soma);
    menu();
}

static void funcao5(int[] b)
{
    int soma = 0;
    Console.WriteLine("Imprimindo a soma valores ímpares do vetor B maiores que 2:");
    for (int i = 0; i < b.Length; i++)
    {
        if (b[i] > 2 && b[i] % 2 == 1)
        {
            soma += b[i];
        }
        Console.WriteLine(soma);
    }
    menu();
}

menu();
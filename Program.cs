using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Menu();                    // Função a ser executada
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Bem vindo(a) ao meu Cronômetro feito em CSharp.");
        Console.WriteLine("Digite o tempo desejado junto com s para segundos ou m para minutos, ou digite 0 para sair.");
        Console.WriteLine(" ");
        Console.WriteLine("Quanto tempo desejas contar ? (exemplo : 5s ou 5 min)");
        string data = Console.ReadLine()!.ToLower();
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));
        int multiplier = 1;

        if (type == 'm')
        {
            multiplier = 60;
        }

        if ( time == 0)
        System.Environment.Exit(0);

        PreStart(time * multiplier);
    }

    static void PreStart(int time)
    {
        Console.Clear();
    Console.WriteLine("Preparar ...");
    Thread.Sleep(1000);
    Console.WriteLine("Apontar ...");
    Thread.Sleep(1000);
    Console.WriteLine("Vai ...");
    Thread.Sleep(2000);

    Start(time);
    }
    static void Start(int time = 6)   // Função
    {
        int currentTime = 0;
        while (currentTime != time)             // Estrutura do Cronômetro
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Cronômetro encerrado com sucesso .");
        Thread.Sleep(2500);
        Menu();
    }
}
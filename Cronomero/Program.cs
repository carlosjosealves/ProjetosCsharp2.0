using System;
namespace Cronometro
{
    class Temporizador
    {
        static void Main(String[] args)
        {
            menu();
        }
        static void menu()
        {

            Console.Clear();
            Console.WriteLine("S = Segundos.");
            Console.WriteLine("M = Minutos.");
            Console.WriteLine("0 = Sair.");
            Console.WriteLine("Digite a opção desejada.");
            String data = Console.ReadLine().ToLower();
            var Type = char.Parse(data.Substring(data.Length - 1, 1));
            int Tempo = int.Parse(data.Substring(0, data.Length - 1));
            int Multplayer = 1;

            if (Type == 'm')
                Multplayer = 60;

            if (Tempo == 0)
                System.Environment.Exit(0);
            PreStart(Tempo * Multplayer);
            menu();
        }
        static void PreStart(int Time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!...");
            Thread.Sleep(2000);
            Start(Time);
        }
        static void Start(int Time)
        {

            int currentTime = 0;
            while (currentTime != Time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);

            }
            Console.Clear();
            Console.WriteLine("Fim da contagem...");
            Thread.Sleep(1000);
            menu();
        }
    }

}



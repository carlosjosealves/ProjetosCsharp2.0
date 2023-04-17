int opcao;
double valor1, valor2, resultado;
do
{
    Console.WriteLine("PROGRAMA CALCULAORA");
    Console.WriteLine("Informe os dados");
    Console.WriteLine("1- Somar");
    Console.WriteLine("2- subtração");
    Console.WriteLine("3- Multiplicação");
    Console.WriteLine("4- Divisão");
    Console.WriteLine("0- Sair");
    Console.WriteLine("Informe o valor 1");
    Console.WriteLine("Informe o valor 1");
    opcao = int.Parse(Console.ReadLine());
    valor1 = 0;
    valor2 = 0;
    resultado = 0;

    if (opcao == 0)
    {
        Console.WriteLine("ate mais");
    }
    else
    {
        switch (opcao)
        {
            case 0:
                Console.WriteLine("thaw!");
                break;
            case 1:
                resultado = Somar(valor1, valor2);
                break;
            case 3:
                resultado = Subtrair(valor1, valor2);
                break;
            case 4:
                resultado = Multiplicar(valor1, valor2);
                break;
            case 5:
                resultado = Dividir(valor1, valor2);
                break;


        }
    }
    Console.ReadKey();
} while (opcao != 0);
static double Somar(double valor1, double valor2)
{
    return valor1 + valor2;
}
static double Subtrair(double valor1, double valor2)
{
    return valor1 - valor2;
}
static double Multiplicar(double valor1, double valor2)
{
    return valor1 * valor2;
}
static double Dividir(double valor1, double valor2)
{
    if (valor2 == 0)
    {
        Console.WriteLine("Não foi possivel fazer a divisão.");
        return 0;
    }
    return valor1 / valor2;
}
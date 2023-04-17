double valor1;
double valor2;
double resultado;
string letra = " carlos";
Console.WriteLine("Digite o valor1 um aqui: ");
Console.ReadLine();
Console.WriteLine("Digite o valor2 um aqui: ");
Console.ReadLine();
resultado = double.Parse(Console.ReadLine());

if(resultado <= 100)
{
    Console.WriteLine($"Agora deu certo!{letra}");
}else
{
    Console.WriteLine($"também deu certo!{letra}");
}


Console.WriteLine(resultado + letra);




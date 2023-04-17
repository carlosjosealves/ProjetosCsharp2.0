int opcao;
float senha;
TelaApresentação();
Console.WriteLine("digite sua senha: ");
senha = float.Parse(Console.ReadLine());
Console.Beep();
Console.Clear();
if(senha ==69){ 
do{    
Console.WriteLine("Digite a opção desejada:\n");
Console.WriteLine("1-Cadastros de clientes: ");
Console.WriteLine("2-Cadastros de funcionários: ");
Console.WriteLine("3-Cadastros de colaboradores:");
Console.WriteLine("4-Cadastros de mercadorias: ");
Console.WriteLine("5-Calcular metas do mês: ");
Console.WriteLine("99-Para sair do programa.");
opcao = int.Parse(Console.ReadLine());
Console.Beep();
Console.Clear();
if(opcao == 1)
{
   Clientes();
}
if(opcao == 2)
{
  Funcionarios();
}
if(opcao == 3)
{
 Colaboradores(); 
}
if(opcao == 4)
{
   CadastroMercadorias();
}
if(opcao == 5)
{
   
   float meta1,meta2,meta3,meta4,total;
   Console.WriteLine("Calcular metas do mês: \n");
   Console.WriteLine("Digite sua primeira meta atingida.");
   Console.Beep();
   meta1 = float.Parse(Console.ReadLine());
   Console.WriteLine("Digite sua segunda meta atingida.");
   Console.Beep();
   meta2 = float.Parse(Console.ReadLine());
   Console.WriteLine("Digite sua terceira meta atingida.");
   Console.Beep();
   meta3 = float.Parse(Console.ReadLine());
   Console.WriteLine("Digite sua quarta meta atingida.");
   Console.Beep();
   meta4 = float.Parse(Console.ReadLine());  
   
   Console.Clear();   
   if(CalcularMetas(meta1,meta2,meta3,meta4) >= 30)
   {
      Console.WriteLine($"Você conseguiu sua meta foi: {total} \n " );     
   }else
   {
      Console.WriteLine($"Você não conseguiu sua meta foi: {total}\n ");
   }   
}
}while(opcao != 99);
}else
{
   Console.WriteLine("senha incorreta!");
}

static void Clientes()
{
   Console.WriteLine("Cadastros de clientes: \n");
   Console.WriteLine(" 1-Nome: ");
   Console.ReadLine();
   Console.WriteLine(" 2- Sobrenome: ");
   Console.ReadLine();
   Console.WriteLine(" 3- CPF: ");
   Console.ReadLine();
   Console.WriteLine("4- Cidade:");
   Console.ReadLine();
   Console.Beep();
   Console.Clear();

}
static void Funcionarios()
{
   Console.WriteLine("Cadastros de funcionários: \n");
   Console.WriteLine("1-Nome: ");
   Console.ReadLine();
   Console.Beep();
   Console.WriteLine("2-Sobrenome: ");
   Console.ReadLine();
   Console.Beep();
   Console.WriteLine("3-CPF: ");
   Console.ReadLine();
   Console.Beep();
   Console.WriteLine("4-Cidade:");
   Console.ReadLine();
   Console.Beep();
   Console.Clear();
}
static void Colaboradores()
{
  Console.WriteLine("Cadastros de colaboradores: \n");
   Console.WriteLine("1-Nome: ");
   Console.ReadLine();
   Console.WriteLine("2-Sobrenome: ");
   Console.ReadLine();
   Console.WriteLine("3-CPF: ");
   Console.ReadLine();
   Console.Beep();
   Console.Clear();
}
static void CadastroMercadorias()
{
 Console.WriteLine("Cadastros de mercadorias: \n");
   Console.WriteLine("1-Nome: ");
   Console.ReadLine();
   Console.WriteLine("2-Sobrenome: ");
   Console.ReadLine();
   Console.WriteLine("3-CPF: ");
   Console.ReadLine();
   Console.Beep();
   Console.Clear();
}
static float CalcularMetas(float meta1,float meta2, float meta3,float meta4 )
{
   float total = 30;
   total = (meta1 + meta2 + meta3 + meta4) / 4;
   return total;
   
}
static void TelaApresentação()
{
Console.Clear();
Console.WriteLine("Bem vindo ao Sistema de cadastro");
Console.WriteLine("Versão 2.0 ");
Console.WriteLine("Desenvolvido por tandera.com\n");


}
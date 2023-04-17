/*int opcao;

Console.WriteLine("Seja bem vindo ao sistema de cadastro.");
Console.WriteLine("Versão 1.0.");
Console.WriteLine("Desenvolvido por Carlos José.");
Console.WriteLine();
Console.Beep();
do{
   Console.WriteLine();
   Console.WriteLine("Digite a opção desejada:");
   Console.WriteLine("1- cadastrar aluno.");
   Console.WriteLine("2- cadastrar professor.");
   Console.WriteLine("3- cadastrar funcionario.");
   Console.WriteLine("99- para sair.");
   opcao = int.Parse(Console.ReadLine());

   if(opcao == 1){ 
     CadastrarAluno();
  }  
   if(opcao == 2){
    CadastrarProfessor();
  }
    if(opcao == 3){
   cadastrarFuncionario();
   }

}while(opcao != 99);

static void CadastrarAluno()
{  String Nome;
   int NP;
   String Cidade;
   Console.WriteLine("cadastrar aluno:");
   Console.WriteLine("Nome: ");
   Console.ReadLine();
   Console.WriteLine("NP:");
   Console.ReadLine();
   Console.WriteLine("Cidade:"); 
   Console.ReadLine();
}

static void CadastrarProfessor()
{   String Professor;
    String cpf;
    Console.WriteLine("Cadastrar professor:");
    Console.WriteLine("Nome:");
    Console.ReadLine();
    Console.WriteLine("CPF");
    Console.ReadLine();
}
static void cadastrarFuncionario()
{   String funcionarioNome;

    int CPF;
    String Cidade;
    Console.WriteLine("cadastrar funcionario:");
    Console.WriteLine("Nome:");
    Console.ReadLine();
    Console.WriteLine("CPF");
    Console.ReadLine();
    Console.WriteLine("Cidade:");
    Console.ReadLine();
}



int numero;
int contador;
Console.WriteLine("Digite seu numero aqui: ");
numero = int.Parse(Console.ReadLine());
for(contador = 0; contador <= 10; contador++)
{
   Console.WriteLine("{0} x {1} = {2}", numero,contador,numero * contador);

}
double salario;
double aumento;
double salarioAtual;
Console.WriteLine("digite seu salario aqui:");
salario = double.Parse(Console.ReadLine());
Console.Beep();
aumento = salario * 30 / 100;
salarioAtual = salario + aumento;
Console.WriteLine(" Esse é seu aumento: " + aumento );
Console.WriteLine("\nO seu salario atual apartir de agora é: "+ salarioAtual);

int numero;
Console.WriteLine("Digite seu numero aqui:");
numero = int.Parse(Console.ReadLine());
   if(numero > 80)
   {
      Console.WriteLine("O numero é maior que 80.");
   }else if(numero < 80)
   {
      Console.WriteLine("O numéro é menor que 80.");
   }else if(numero == 80)
   {
      Console.WriteLine("Você acertou o valor desejado, pode ir para disney. kkkk");
   }else{
      Console.WriteLine("Valor incorreto!");
   }
   int contador;
   for(contador = 0; contador < 10; contador++)
   {
      Console.WriteLine(contador + " Deus é amor!");
   }
   int quantidade;
   quantidade = int.Parse(Console.ReadLine());
   while(quantidade > 0 )
   {
      Console.WriteLine(quantidade + " = Jessus Cristo.\n");
      quantidade--;
   }*/ 

int opcao;
Console.WriteLine("Bem vindo ao sistema dos Thundercats.\n");
Console.WriteLine("Desenvolvido por Tandera.com");
Console.WriteLine("Versão 10.0\n\n");
Console.Beep();
do{
Console.WriteLine("Digite a opção para ter acesso aos cadastros.\n");
Console.WriteLine("1 - Clintes.\n");
Console.WriteLine("2- Funcionarios.\n");
Console.WriteLine("3- Colaboradores.\n");
Console.WriteLine("99- opção de saida.\n");
opcao = int.Parse(Console.ReadLine());
if(opcao == 1)
{ 
   clientes();
}else if(opcao == 2)
{  
   funcionarios();
}else if(opcao == 3)
{  
   Colaboradores();
}
}while(opcao != 99);
static void clientes()
{
   Console.WriteLine("Cadastros dos Clintes.\n");
   Console.WriteLine("Nome:");
   Console.ReadLine();
   Console.WriteLine("CPF:");
   Console.ReadLine();
   Console.WriteLine("Cidade:\n");
   Console.ReadLine();

}
static void funcionarios()
{
   Console.WriteLine("Cadastros dos funcionarios.\n");
   Console.WriteLine("Nome:");
   Console.ReadLine();
   Console.WriteLine("CPF:");
   Console.ReadLine();
   Console.WriteLine("Cidade:\n");
   Console.ReadLine();

}
static void Colaboradores()
{
   Console.WriteLine("Cadastros dos Colaboradores.\n");
   Console.WriteLine("Nome:");
   Console.ReadLine();
   Console.WriteLine("CPF:");
   Console.ReadLine();
   Console.WriteLine("Cidade:\n");
   Console.ReadLine();
}
Console.ReadKey();



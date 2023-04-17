using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootcamp.C_.Models
{
    public class Cadastro
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()

        {     
              Console.WriteLine($"\n Olá meu nome é {Nome} é tenho {Idade} de idade.\n");
             
        }
    }
}
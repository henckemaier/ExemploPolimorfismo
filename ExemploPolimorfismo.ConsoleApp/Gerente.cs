using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPolimorfismo.ConsoleApp
{
    class Gerente : Imposto //<-HERANÇA
    {
        //metodo
        public override void valeAlimentacao(double salario) //override vai sobreescrever o metodo do imposto
        {
            Console.WriteLine("Desconto gerente do vale alimentação R$" + (salario * 0.15)); //desconto de 15%
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPolimorfismo.ConsoleApp
{
    class Atendente : Imposto //<-HERANÇA
    {
        public override void valeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto atendente do vale alimentação R$" + (salario * 0.12)); //desconto de 12%
        }
    }
}

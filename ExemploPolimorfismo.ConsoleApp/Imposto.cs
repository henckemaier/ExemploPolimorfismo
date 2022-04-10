using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPolimorfismo.ConsoleApp
{
    class Imposto
    {
        //Metodos
        public virtual void valeAlimentacao(double salario) //virtual permite outras classes sobreescreverem ele
        {
            Console.WriteLine("Desconto padrão do vale alimentação R$" + (salario * 0.1)); //descontar 10% do salario bruto do colaborador
        }

        public void valeTransporte(double salario)
        {
            Console.WriteLine("Desconto padrão do vale transporte R$" + (salario * 0.06)); //desconto de 6%
        }
    }
}

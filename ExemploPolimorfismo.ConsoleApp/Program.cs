using System;

namespace ExemploPolimorfismo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instancia estagiario
            Imposto objetoE = new Estagiario(); //objetoE vai ter acesso ao vale alimentacao e o
                                                //estagiario vai sobreescrever

            objetoE.valeAlimentacao(1000);      //como a classe estagiario não tem nada,
                                                //o imposto sera o mesmo
            objetoE.valeTransporte(1000);
            Console.WriteLine("--------");

            //instancia gerente
            Imposto objetoG = new Gerente();

            objetoG.valeAlimentacao(5000);
            objetoG.valeTransporte(5000);
            Console.WriteLine("--------");

            //instancia atendente
            Imposto objetoA = new Atendente();

            objetoG.valeAlimentacao(2000);
            objetoG.valeTransporte(2000);

            Console.ReadLine();
        }
    }
}

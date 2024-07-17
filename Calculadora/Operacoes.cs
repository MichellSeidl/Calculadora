using System;
using System.Collections;
using System.Collections.Generic;
namespace Calculadora
{
    public class Operacoes
    {
        public long valorA {get;set;}
        public char operador { get; set; }
        public long valorB { get; set; }
        public decimal resultado { get; set; }
        public void ExibeOperacoes(Queue<Operacoes> filaOperacoes)
        {
            Console.WriteLine("Operações restantes na fila:");
            foreach (Operacoes op in filaOperacoes)
            {
                Console.WriteLine("{0} {1} {2} ", op.valorA, op.operador, op.valorB);
            }
        }
    }
}

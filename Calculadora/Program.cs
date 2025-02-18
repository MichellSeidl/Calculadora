﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' }); //Implemente o calculo de divisao

            Calculadora calculadora = new Calculadora();

            Stack<decimal> resultados = new Stack<decimal>();
            
            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Peek();
                operacao.ExibeOperacoes(filaOperacoes);
                calculadora.calcular(operacao);
                resultados.Push(operacao.resultado);
                Console.WriteLine("\n{0} {1} {2} = {3}\n", operacao.valorA,operacao.operador,operacao.valorB, operacao.resultado);
                filaOperacoes.Dequeue();
            }

            Stack<decimal> resultados2 = new Stack<decimal>(resultados.ToArray());

            foreach (decimal resultado in resultados2)
            {
                Console.WriteLine(resultado);
            }


        }
    }
}

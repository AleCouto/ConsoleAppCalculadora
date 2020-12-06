using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
        //inicio_main:
            Console.WriteLine("Bem vindo ao programa Calculadora");
            Console.WriteLine("Selecione a operação Soma[s], Subtração[b], Multiplicação[m], Divisão[d]");
            char escolha = char.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 's':
                case 'S':
                    soma();
                    break;

                case 'b':
                case 'B':
                    Subtracao();
                    break;

                case 'm':
                case 'M':
                    Multiplicacao();
                    break;

                case 'd':
                case 'D':
                    Divisao();
                    break;
            }

            static void soma()
            {
                inicio_soma:
                Console.Clear();
                int s1, s2, res;
                Console.WriteLine("Soma");
                Console.WriteLine("Entre com o primeiro valor");
                s1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Entre com o segundo valor");
                s2 = int.Parse(Console.ReadLine());
                res = s1 + s2;
                Console.WriteLine("A Soma de {0} + {1} = {2}", s1, s2, res);
                Console.WriteLine("Deseja fazer nova soma [s/n]");
                int escolha2 = char.Parse(Console.ReadLine());

                if (escolha2 == 's' || escolha2 == 'S')
                {
                    goto inicio_soma;
                }
                else
                {
                    //goto inicio_main;
                    Console.WriteLine("FIM");
                }
            }

            static void Subtracao()
            {
                inicio_sub:
                Console.Clear();
                int s1, s2, res;
                Console.WriteLine("Subtração");
                Console.WriteLine("Entre com o primeiro valor");
                s1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Entre com o segundo valor");
                s2 = int.Parse(Console.ReadLine());
                res = s1 - s2;
                Console.WriteLine("A Subtração de {0} - {1} = {2}", s1, s2, res);
                Console.WriteLine("Deseja fazer nova subtração [s/n]");
                int escolha2 = char.Parse(Console.ReadLine());

                if (escolha2 == 's' || escolha2 == 'S')
                {
                    goto inicio_sub;
                }
                else
                {
                    //goto inicio_main;
                    Console.WriteLine("FIM");
                }
            }

            static void Multiplicacao()
            {
                inicio_multi:
                Console.Clear();
                int s1, s2, res;
                Console.WriteLine("Multiplicação");
                Console.WriteLine("Entre com o primeiro valor");
                s1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Entre com o segundo valor");
                s2 = int.Parse(Console.ReadLine());
                res = s1 * s2;
                Console.WriteLine("A Multiplicação de {0} * {1} = {2}", s1, s2, res);
                Console.WriteLine("Deseja fazer nova Multiplicação [s/n]");
                int escolha2 = char.Parse(Console.ReadLine());

                if (escolha2 == 's' || escolha2 == 'S')
                {
                    goto inicio_multi;
                }
                else
                {
                    //goto inicio_main;
                    Console.WriteLine("FIM");
                }
            }

            static void Divisao()
            {
            inicio_multi:
                Console.Clear();
                int s1, s2, res;
                Console.WriteLine("Divisão");
                Console.WriteLine("Entre com o primeiro valor");
                s1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Entre com o segundo valor");
                s2 = int.Parse(Console.ReadLine());
                res = s1 / s2;
                Console.WriteLine("A Divisão de {0} / {1} = {2}", s1, s2, res);
                Console.WriteLine("Deseja fazer nova Multiplicação [s/n]");
                int escolha2 = char.Parse(Console.ReadLine());

                if (escolha2 == 's' || escolha2 == 'S')
                {
                    goto inicio_multi;
                }
                else
                {
                    //goto inicio_main;
                    Console.WriteLine("FIM");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3Parte2.cs
{
    public  class Program
    {

        public static void Main(string[] args)
        {

            int opcao;

            Console.WriteLine("===========================================================================================");
            Console.WriteLine("|23 -   Escolha uma das  opções  Adição, subtração, multiplicação, divisão                |");                                                 |");
            Console.WriteLine("|24 -   Verificar número                                                                  |");
            Console.WriteLine("|25 -   Peso ideal                                                                        |");
            Console.WriteLine("|26 -   Números decrescente                                                               |");
            Console.WriteLine("|27 -   Calculo do fatorial                                                               |");
            Console.WriteLine("|28 -   Impares de 100 a 200                                                              |");
            Console.WriteLine("|29 -   Números de 1 a 2000                                                               |");
            Console.WriteLine("|30 -   Tabuada                                                                           |");
            Console.WriteLine("|31 -   Positivo, par ou impar                                                            |");
            Console.WriteLine("|32 -   soma do quadrado dos números                                                      |");
            Console.WriteLine("|33 -   Média do s alunos de uma turma                                                    |");
            Console.WriteLine("|34 -   Conjunto de números positivos                                                     |");
            Console.WriteLine("|35 -   Multiplos de 10                                                                   |");
            Console.WriteLine("|36 -   Valores inteiros e positivos                                                      |");
            Console.WriteLine("|37 -   Conversão base númerica                                                           |");
            Console.WriteLine("|38 -   Variaveis C e n                                                                   |");
            Console.WriteLine("|39 -   Par ou impar                                                                      |");
            Console.WriteLine("|40 -   Calculo da poluição                                                               |");
            Console.WriteLine("|41 -   Idade nadador                                                                     |");
            Console.WriteLine("|42 -   Maior e menor numero entre n                                                      |");
            Console.WriteLine("|43 -   Calcular número de graos                                                          |");
            Console.WriteLine("|44 -   Exiba as opçoes                                                                   |");
            Console.WriteLine("===========================================================================================");
            Console.WriteLine("Escolha uma opcao:  ");
            opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 1:

                    Atividade exercicio1 = new Atividade();

                    exercicio1.Atividade23();


                    break;
                case 2:
                    Atividade exercicio2 = new Atividade();

                    exercicio2.Atividade24();


                    break;
                case 3:
                    Atividade exercicio3 = new Atividade();

                    exercicio3.Atividade25();



                    break;
                case 4:
                    Atividade exercicio4 = new Atividade();

                    exercicio4.Atividade26();



                    break;
                case 5:
                    Atividade exercicio5 = new Atividade();

                    exercicio5.Atividade27();



                    break;
                case 6:
                    Atividade exercicio6 = new Atividade();

                    exercicio6.Atividade28();



                    break;
                case 7:
                    Atividade exercicio7 = new Atividade();

                    exercicio7.Atividade29();


                    break;
                case 8:
                    Atividade exercicio8 = new Atividade();

                    exercicio8.Atividade30();


                    break;
                case 9:
                    Atividade exercicio9 = new Atividade();

                    exercicio9.Atividade31();



                    break;
                case 10:
                    Atividade exercicio10 = new Atividade();

                    exercicio10.Atividade32();



                    break;
                case 11:
                    Atividade exercicio11 = new Atividade();

                    exercicio11.Atividade33();


                    break;
                case 12:
                    Atividade exercicio12 = new Atividade();

                    exercicio12.Atividade34();


                    break;
                case 13:
                    Atividade exercicio13 = new Atividade();

                    exercicio13.Atividade35();

                    break;
                case 14:
                    Atividade exercicio14 = new Atividade();

                    exercicio14.Atividade36();

                    break;
                case 15:
                    Atividade exercicio15 = new Atividade();

                    exercicio15.Atividade37();

                    break;
                case 16:
                    Atividade exercicio16 = new Atividade();

                    exercicio16.Atividade38();

                    break;
                case 17:
                    Atividade exercicio17 = new Atividade();

                    exercicio17.Atividade39();

                    break;
                case 18:
                    Atividade exercicio18 = new Atividade();

                    exercicio18.Atividade40();

                    break;
                case 19:
                    Atividade exercicio19 = new Atividade();

                    exercicio19.Atividade41();

                    break;
                case 20:
                    Atividade exercicio20 = new Atividade();

                    exercicio20.Atividade42();

                    break;
                case 21:
                    Atividade exercicio21 = new Atividade();

                    exercicio21.Atividade43();

                    break;
                case 22:
                    Atividade exercicio22 = new Atividade();

                    exercicio22.Atividade44();

                    break;


                default:
                    Console.WriteLine("Opção Invalida!");
                    break;



            }


        }

    }
}

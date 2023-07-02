using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3Parte2.cs
{
     class Atividade
    {

        public void Atividade23()
        {
            double primeiron, segundon, resultado = 0;
            int esccolha;

            Console.WriteLine("escolha uma das operações a segue");
            Console.WriteLine("");
            Console.WriteLine("1-Adição,2-Subtração,3-Multiplicação,4-Divisão");
            esccolha = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número");
            int Primeiron = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o sugundo número");
            int Segundon = int.Parse(Console.ReadLine());
            switch (esccolha)
            {
                case 1:
                    resultado = Primeiron + Segundon;
                    Console.WriteLine("a soma dos números é: " + resultado);
                    break;

                case 2:
                    resultado = Primeiron - Segundon;
                    Console.WriteLine("a subtração dos números é: " + resultado);
                    break;

                case 3:
                    resultado = Primeiron * Segundon;
                    Console.WriteLine("a multiplicação dos números é: " + resultado);
                    break;

                case 4:
                    resultado = Primeiron / Segundon;
                    Console.WriteLine("a divisão dos números é: " + resultado);
                    break;
            }


        }
        public void Atividade24()
        {
            double PrimeiroNumero, SegundoNumero, Resultado = 0;
            int escolha = 0;

            Console.WriteLine("Escolha umas das opções a seguir");
            Console.WriteLine("");
            Console.WriteLine("1-Verificar se um dos números lidos é ou não múltiplo do outro");
            Console.WriteLine("2-Verificar se os dois números lidos são pares");
            Console.WriteLine("3-Verificar se a média dos números é maior ou igual a 7");
            Console.WriteLine("4-sair");
            if (int.TryParse(Console.ReadLine(), out escolha))
                Console.Clear();

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Digite o primeiro número: ");
                    PrimeiroNumero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    SegundoNumero = int.Parse(Console.ReadLine());
                    Console.ReadKey();

                    if (PrimeiroNumero % SegundoNumero == 0 || SegundoNumero % PrimeiroNumero == 0)
                    {
                        Console.WriteLine("Sim, um dos números é múltiplo do outro");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Não, nenhum dos números é múltiplos do outro");
                        Console.ReadKey();
                    }

                    break;

                case 2:
                    Console.WriteLine("Digite o primeiro número: ");
                    PrimeiroNumero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    SegundoNumero = int.Parse(Console.ReadLine());
                    Console.ReadKey();
                    if (PrimeiroNumero % 2 == 0 && SegundoNumero % 2 == 0)
                    {
                        Console.WriteLine(" os dois números lidos são pares.");
                        Console.ReadKey();
                    }
                    else if (PrimeiroNumero % 2 == 0 || SegundoNumero % 2 == 0)
                    {
                        Console.WriteLine("apenas um dos número lidos é par ");
                    }
                    else
                    {
                        Console.WriteLine("nenhum  dos número lidos é par.");
                        Console.ReadKey();
                    }
                    break;

                case 3:
                    Console.WriteLine("Digite o primeiro número: ");
                    PrimeiroNumero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    SegundoNumero = int.Parse(Console.ReadLine());
                    Console.ReadKey();
                    if ((PrimeiroNumero + SegundoNumero) / 2 >= 7)
                    {
                        Console.WriteLine("Sim, a média dos dois números é maior ou igual a 7.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Não, a média dos dois números não é maior ou igual a 7.");
                        Console.ReadKey();
                    }
                    break;
                case 4:

                    break;
            }
            while (escolha != 1) ;



        }
        public void Atividade25()
        {
            string sexo;
            decimal pesoIdeal = 0;
            Console.WriteLine("digite o seu sexo, digite f para femenino e m para masculino");
            sexo = Console.ReadLine().ToUpper();
            if (sexo != "F" && sexo != "M") ;
            Console.WriteLine(" digite novamente");
            while (sexo != "F" && sexo != "M") ;
            if (sexo == "M")
            {
                Console.WriteLine(" digite a sua altura:");
                decimal h = decimal.Parse(Console.ReadLine());
                pesoIdeal = (decimal.Parse("72,7") * h) - 58;
            }
            if (sexo == "F")
            {
                Console.WriteLine("digite a sua altura:");
                decimal h = decimal.Parse(Console.ReadLine());
                pesoIdeal = (decimal.Parse("62,1") * h) - decimal.Parse("44,7");
            }
            Console.WriteLine($"o peso ideal é:{pesoIdeal}");
            Console.ReadKey();


        }
        public void Atividade26()
        {
            int[] numeros = new int[100];
            Console.WriteLine("digite 100 numeros:");
            for (int x = 0; x < 100; x++)
            {
                numeros[x] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("os numeros em ordem decrescente são:");
            Array.Sort(numeros);
            Array.Reverse(numeros);
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();



        }
        public void Atividade27()
        {
        
                Console.WriteLine("Digite a quantidade de números a serem processados:");
                int quantidade = int.Parse(Console.ReadLine());

                for (int x = 1; x <= quantidade; x++)
                {
                    Console.WriteLine("Digite o número #" + x + ":");
                    int numero = int.Parse(Console.ReadLine());

                    long fatorial = CalcularFatorial(numero);
                    Console.WriteLine("O fatorial de " + numero + " é: " + fatorial);
                    Console.WriteLine();
                }
            

            static long CalcularFatorial(int numero)
            {
                long fatorial = 1;

                for (int x = 1; x <= numero; x++)
                {
                    fatorial *= x;
                }

                return fatorial;
            }
        


        }
        public void Atividade28()
        {
           int[] numeros = new int[200];
           int x;
           Console.WriteLine("");
           Console.WriteLine("Digite 200 números:");
          for (x = 0; x < 200; x++)
          {
            numeros[x] = int.Parse(Console.ReadLine());

          }
          Console.WriteLine("");
          Console.WriteLine("Os números impares informados foram:");
          Array.Sort(numeros);

            for (x = 0; x < 200; x++)
            {

            if (numeros[x] % 2 == 1)
            {


                Console.WriteLine(numeros[x]);
            }
        }



        }
        public void Atividade29()
        {
        int[] numeros = new int[2000];
        Console.WriteLine("digite de 1 ate  2000:");
        for (int x = 0; x < 2000; x++)
            numeros[x] = int.Parse(Console.ReadLine());

        Console.WriteLine("os numeros são:");
        Array.Sort(numeros);
        foreach (int numero in numeros)
            Console.WriteLine(numero);



        }
        public void Atividade30()
        {
            int cont = 1;
            Console.Write("DIGITE UM NUMERO PARA A TABUADA: ");
            int numero = int.Parse(Console.ReadLine());
            while (cont <= 10)
            {
                Console.WriteLine(numero + "x" + cont + "=" + numero * cont);
                cont++;
            }


        }
        public void Atividade31()
        {
       
                int numero;
                int somaPares = 0;
                int somaImpares = 0;

                Console.WriteLine("Digite um número positivo (ou um número negativo para encerrar):");

                do
                {
                    numero = int.Parse(Console.ReadLine());

                    if (numero > 0)
                    {
                        if (numero % 2 == 0)
                        {
                            Console.WriteLine("{0} é par", numero);
                            somaPares += numero;
                        }
                        else
                        {
                            Console.WriteLine("{0} é ímpar", numero);
                            somaImpares += numero;
                        }
                    }
                } while (numero >= 0);

                Console.WriteLine("Soma dos números pares: {0}", somaPares);
                Console.WriteLine("Soma dos números ímpares: {0}", somaImpares);

                Console.ReadLine();
            
        


        }
        public void Atividade32()
        {
            Console.Write("Digite um número (menor que 10 e maior que zero): ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0 && numero < 10)
            {
                int somaQuadrados = 0;
                int contador = 0;
                int numeroImpar = numero % 2 == 0 ? numero + 1 : numero; 

                while (contador < 20)
                {
                    somaQuadrados += numeroImpar * numeroImpar;
                    numeroImpar += 2;
                    contador++;
                }

                Console.WriteLine("A soma dos quadrados dos 20 primeiros números ímpares a partir de " + numero + " é: " + somaQuadrados);
            }
            else
            {
                Console.WriteLine("O número informado está fora do intervalo válido.");
            }

        }


        public void Atividade33()
        {

            int matricula;
            double nota;
            int contadorAlunos = 0;
            double somaNotas = 0;

            Console.WriteLine("Digite o número de matrícula do aluno (ou um número negativo para encerrar):");

            do
            {
                Console.Write("Número de matrícula: ");
                matricula = int.Parse(Console.ReadLine());

                if (matricula >= 0)
                {
                    Console.Write("Nota na prova: ");
                    nota = double.Parse(Console.ReadLine());

                    contadorAlunos++;
                    somaNotas += nota;
                }
            } while (matricula >= 0);

            if (contadorAlunos > 0)
            {
                double media = somaNotas / contadorAlunos;
                Console.WriteLine("Média das notas: {0}", media);
            }
            else
            {
                Console.WriteLine("Nenhum aluno inserido.");
            }
        }

        public void Atividade34()
        {
            int numero;
            int menor = int.MaxValue;
            int maior = int.MinValue;

            Console.WriteLine("Digite um número positivo (ou um número negativo para encerrar):");

            do
            {
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    if (numero < menor)
                    {
                        menor = numero;
                    }

                    if (numero > maior)
                    {
                        maior = numero;
                    }
                }
            } while (numero >= 0);

            if (menor == int.MaxValue)
            {
                Console.WriteLine("Nenhum número foi inserido.");
            }
            else
            {
                Console.WriteLine("Menor número: {0}", menor);
                Console.WriteLine("Maior número: {0}", maior);
            }


        }
        public void Atividade35()
        {

            for (int x = 1; x <= 100; x++)
            {
                Console.WriteLine(x);

                if (x % 10 == 0)
                {
                    Console.WriteLine("Múltiplo de 10");
                }
            }

            Console.ReadLine();
        }


        public void Atividade36()
        {
            const int quantidadeValores = 10;
            int maior = int.MinValue;
            int menor = int.MaxValue;
            int soma = 0;

            Console.WriteLine("Digite {0} valores inteiros e positivos:", quantidadeValores);

            for (int i = 0; i < quantidadeValores; i++)
            {
                int valor = LerValorInteiroPositivo();

                if (valor > maior)
                {
                    maior = valor;
                }

                if (valor < menor)
                {
                    menor = valor;
                }

                soma += valor;
            }

            double media = (double)soma / quantidadeValores;

            Console.WriteLine("Maior valor: {0}", maior);
            Console.WriteLine("Menor valor: {0}", menor);
            Console.WriteLine("Média dos valores: {0}", media);

            Console.ReadLine();
        }

        public void Atividade37()
        {
            bool voltarAoMenu = true;

            do
            {
                Console.WriteLine("=== Menu Principal ===");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Encerrar o programa");
                Console.Write("Informe a opção desejada: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        RealizarOperacao("Adição", (a, b) => a + b);
                        break;
                    case "2":
                        RealizarOperacao("Subtração", (a, b) => a - b);
                        break;
                    case "3":
                        RealizarOperacao("Multiplicação", (a, b) => a * b);
                        break;
                    case "4":
                        RealizarOperacao("Divisão", (a, b) =>
                        {
                            if (b != 0)
                            {
                                return (double)a / b;
                            }
                            else
                            {
                                Console.WriteLine("Divisão por zero não é permitida.");
                                return 0;
                            }
                        });
                        break;
                    case "5":
                        voltarAoMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine();
            } while (voltarAoMenu);

            Console.WriteLine("Programa encerrado.");
            Console.ReadLine();
        }

        static void RealizarOperacao(string nomeOperacao, Func<int, int, double> operacao)
        {
            Console.WriteLine();
            Console.WriteLine("=== {0} ===", nomeOperacao);
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            double resultado = operacao(num1, num2);
            Console.WriteLine("Resultado: {0}", resultado);

            Console.WriteLine();
            Console.Write("Deseja voltar ao menu principal? (S/N): ");
            string resposta = Console.ReadLine();

            if (resposta.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Encerrando o programa...");
                Environment.Exit(0);
            }

        }

        static int LerValorInteiroPositivo()
        {
            int valor;
            bool valorValido;

            do
            {
                Console.Write("Digite um valor inteiro positivo: ");
                string input = Console.ReadLine();

                valorValido = int.TryParse(input, out valor);

                if (!valorValido || valor <= 0)
                {
                    Console.WriteLine("Valor inválido. Digite um valor inteiro positivo.");
                }

            } while (!valorValido || valor <= 0);

            return valor;


        }
        public void Atividade38()
        {
            string opcao = "";
            double e = 0;

            do
            {

                Console.Write("DIGITE O CODIGO: ");
                double c = double.Parse(Console.ReadLine());
                Console.Write("HORAS TRABALHADAS: ");
                double n = double.Parse(Console.ReadLine());


                if (n > 50)
                {
                    e = (n - 50) * 20;
                    Console.Write("SALARIO TOTAL: R$ " + (500 + e));
                    Console.WriteLine("SALARIO EXCEDENTE: R$ " + e);
                }
                else
                {
                    Console.WriteLine("SALARIO TOTAL: R$ " + (n * 10));
                    Console.WriteLine("SALARIO EXCEDENTE: R$ " + e);
                }


                Console.Write("DESEJA ENCERRAR DIGITE 'S': ");
                opcao = Console.ReadLine();
            }
            while (opcao != "s" && opcao != "S");





        }

        public void Atividade39()
        {
            bool encerrarPrograma = false;

            do
            {
                Console.Write("Digite um número inteiro: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número {0} é par.", numero);
                }
                else
                {
                    Console.WriteLine("O número {0} é ímpar.", numero);
                }

                if (numero >= 0)
                {
                    Console.WriteLine("O número {0} é positivo.", numero);
                }
                else
                {
                    Console.WriteLine("O número {0} é negativo.", numero);
                }

                Console.Write("Deseja encerrar o programa? (S/N): ");
                string resposta = Console.ReadLine();

                if (resposta.Equals("S", StringComparison.OrdinalIgnoreCase))
                {
                    encerrarPrograma = true;
                }

                Console.WriteLine();
            } while (!encerrarPrograma);

            Console.WriteLine("Programa encerrado.");
            Console.ReadLine();


        }
        public void Atividade40()
        {
            bool encerrarPrograma = false;

            do
            {
                Console.Write("Digite o índice de poluição medido: ");
                double indicePoluicao = double.Parse(Console.ReadLine());

                if (indicePoluicao >= 0.05 && indicePoluicao < 0.3)
                {
                    Console.WriteLine("Índice de poluição aceitável.");
                }
                else if (indicePoluicao >= 0.3 && indicePoluicao < 0.4)
                {
                    Console.WriteLine("Indústrias do 1º grupo intimadas a suspenderem suas atividades.");
                }
                else if (indicePoluicao >= 0.4 && indicePoluicao < 0.5)
                {
                    Console.WriteLine("Indústrias do 1º e 2º grupos intimadas a suspenderem suas atividades.");
                }
                else if (indicePoluicao >= 0.5)
                {
                    Console.WriteLine("Todos os grupos devem paralisar suas atividades.");
                }
                else
                {
                    Console.WriteLine("Índice de poluição inválido.");
                }

                Console.Write("Deseja encerrar o programa? (S/N): ");
                string resposta = Console.ReadLine();

                if (resposta.Equals("S", StringComparison.OrdinalIgnoreCase))
                {
                    encerrarPrograma = true;
                }

                Console.WriteLine();
            } while (!encerrarPrograma);

            Console.WriteLine("Programa encerrado.");
            Console.ReadLine();


        }

        public void Atividade41()
        {
            Console.WriteLine("Digite a idade do nadador:");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Categoria: Infantil A");
            }
            else if (idade >= 8 && idade <= 11)
            {
                Console.WriteLine("Categoria: Infantil B");
            }
            else if (idade >= 12 && idade <= 13)
            {
                Console.WriteLine("Categoria: Juvenil A");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Categoria: Juvenil B");
            }
            else if (idade >= 18)
            {
                Console.WriteLine("Categoria: Adulto");
            }
            else
            {
                Console.WriteLine("Idade inválida.");
            }


        }
        public void Atividade42()
        {
            int numero;
            int maior = int.MinValue;
            int menor = int.MaxValue;

            do
            {
                Console.WriteLine("Digite um número (ou 0 para sair):");
                numero = int.Parse(Console.ReadLine());

                if (numero != 0)
                {
                    if (numero > maior)
                    {
                        maior = numero;
                    }

                    if (numero < menor)
                    {
                        menor = numero;
                    }
                }
            } while (numero != 0);

            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O menor número é: " + menor);


        }

        public void Atividade43()
        {
            ulong totalGrains = 0;

            for (int x = 0; x < 64; x++)
            {
                ulong grainsOnSquare = (ulong)Math.Pow(2, x);
                totalGrains += grainsOnSquare;
            }

            Console.WriteLine("O número total de grãos esperado pelo monge é: " + totalGrains);


        }

        public void Atividade44()
        {
            char encerrar = 'N';

            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Conversão de Graus Celsius em Graus Fahrenheit");
                Console.WriteLine("2 - Conversão de Graus Fahrenheit em Graus Celsius");
                Console.WriteLine("3 - Peso ideal do homem");
                Console.WriteLine("4 - Peso ideal da mulher");
                Console.WriteLine("S - Encerrar o programa");
                Console.WriteLine();

                Console.Write("Opção: ");
                char opcao = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (opcao)
                {
                    case '1':
                        ConversaoCelsiusParaFahrenheit();
                        break;
                    case '2':
                        ConversaoFahrenheitParaCelsius();
                        break;
                    case '3':
                        PesoIdealHomem();
                        break;
                    case '4':
                        PesoIdealMulher();
                        break;
                    case 'S':
                    case 's':
                        encerrar = 'S';
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine();
            } while (encerrar != 'S');
        }

        static void ConversaoCelsiusParaFahrenheit()
        {
            Console.WriteLine("Conversão de Graus Celsius em Graus Fahrenheit");
            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Temperatura em Fahrenheit: " + fahrenheit);
        }

        static void ConversaoFahrenheitParaCelsius()
        {
            Console.WriteLine("Conversão de Graus Fahrenheit em Graus Celsius");
            Console.Write("Digite a temperatura em Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperatura em Celsius: " + celsius);
        }

        static void PesoIdealHomem()
        {
            Console.WriteLine("Cálculo do Peso Ideal para Homem");
            Console.Write("Digite a altura em centímetros: ");
            double altura = double.Parse(Console.ReadLine());
            double pesoIdeal = (72.7 * altura / 100) - 58;
            Console.WriteLine("Peso ideal: " + pesoIdeal + " kg");

            Console.Write("Digite o peso atual em kg: ");
            double pesoAtual = double.Parse(Console.ReadLine());

            if (pesoAtual < pesoIdeal)
            {
                Console.WriteLine("Você está abaixo do peso ideal.");
            }
            else if (pesoAtual > pesoIdeal)
            {
                Console.WriteLine("Você está acima do peso ideal.");
            }
            else
            {
                Console.WriteLine("Você está no peso ideal.");
            }
        }

        static void PesoIdealMulher()
        {
            Console.WriteLine("Cálculo do Peso Ideal para Mulher");
            Console.Write("Digite a altura em centímetros: ");
            double altura = double.Parse(Console.ReadLine());
            double pesoIdeal = (62.1 * altura / 100) - 44.7;
            Console.WriteLine("Peso ideal: " + pesoIdeal + " kg");


        }































    }
}

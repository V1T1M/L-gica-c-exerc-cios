//using System.Globalization;

//namespace Exercício
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("qual seu nome completo");
//            string a = Console.ReadLine();
//            Console.WriteLine("quantos quartos tem na sua casa?");
//            int b = int.Parse(Console.ReadLine());
//            Console.WriteLine("digite o preço de um produto");
//            double c=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
//            Console.WriteLine("digite seu ultimo nome, sua idade e sua altura (na mesma linha) ");
//            string[] vet = Console.ReadLine().Split(' ');
//            string x = vet[0];
//            int y = int.Parse(vet[1]);
//            double z = double.Parse(vet[2],CultureInfo.InvariantCulture);
//            Console.WriteLine(a);
//            Console.WriteLine(b);
//            Console.WriteLine(c);
//            Console.WriteLine(x);
//            Console.WriteLine(y);
//            Console.WriteLine(z);
//        }
//    }
//}


//namespace Beecrowd
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            do
//            {
//                int a, b;
//                Console.Write("digite um valor: ");
//                a = int.Parse(Console.ReadLine());
//                Console.Write("digite outro valor: ");
//                b = int.Parse(Console.ReadLine());
//                int x = a + b;
//                Console.WriteLine("A soma de " + a + " mais " + b + " é igual a: " + x);
//                Console.WriteLine("Você quer continuar?");
//            } while (Console.ReadLine().ToUpper() == "SIM");
//            Console.WriteLine("blz ent");
//            Console.ReadKey();
//        }
//    }
//}
//using System.Globalization;
//namespace beecrowd1002
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double n = 3.14159, raio, area;
//            raio = double.Parse(Console.ReadLine());
//            area = n * Math.Pow(raio, 2);
//            Console.WriteLine("A = " +area.ToString("f4", CultureInfo.InvariantCulture));
//        }
//    }
//}

////1003
//class BEECROWD
//{

//    static void Main(string[] args)
//    {

//        int A, B, SOMA;
//        A = int.Parse(Console.ReadLine());
//        B = int.Parse(Console.ReadLine());
//        SOMA = A + B;
//        Console.WriteLine("SOMA = " + SOMA);
//    }

//}

////beecrowd 1005
//double A, B, MEDIA;

//    A = double.Parse(Console.ReadLine());
//    B = double.Parse(Console.ReadLine());
//    MEDIA = ((A * 3.5) + (B * 7.5))/11;

//Console.WriteLine("MEDIA = " + MEDIA.ToString("f5"));

//string NOME;
//double SFIXO, VENDAS, TOTAL;
//NOME = Console.ReadLine();
//SFIXO = double.Parse(Console.ReadLine());
//VENDAS = double.Parse(Console.ReadLine());
//TOTAL = SFIXO + (VENDAS * 0.15);
// Console.WriteLine("TOTAL = R$ " + TOTAL.ToString("f2"));




//string n1, n2;
//int id1, id2;
//double media;
//string[] vet = Console.ReadLine().Split(' ');
//n1 = vet[0];
//id1 = int.Parse(vet[1]);

//vet = Console.ReadLine().Split(' ');
//n2 = vet[0];
//id2 = int.Parse(vet[1]);

//media = (double)(id1 + id2) / 2;
//Console.WriteLine(media + " anos");


//double x1, x2, y1, y2,dis;
//string[] vet = Console.ReadLine().Split(' ');
//x1 = double.Parse(vet[0]);
//y1 = double.Parse(vet[1]);

//vet = Console.ReadLine().Split(' ');
//x2 = double.Parse(vet[0]);
//y2 = double.Parse(vet[1]);

//dis = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
//Console.WriteLine(dis.ToString("f4"));


//int N, horas, resto, minutos, segundos;

//N = int.Parse(Console.ReadLine());

//horas = N / 3600;
//resto = N % 3600;

//minutos = resto / 60;
//segundos = resto % 60;

//Console.WriteLine(horas + ":" + minutos + ":" + segundos);

//1018
//1020
//1021
//1061

//using System.Collections.Concurrent;

//namespace beecrowd
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int N, quociente, resto, nota;

//            N = int.Parse(Console.ReadLine());
//            Console.WriteLine(N);

//            resto = N;

//            nota = 100;
//            quociente = resto / nota;
//            Console.WriteLine(quociente + " nota(s) de " + nota + ",00");
//            resto = resto % nota;

//            nota = 50;
//            quociente = resto / nota;
//            Console.WriteLine(quociente + " nota(s) de " + nota + ",00");
//            resto = resto % nota;

//            nota = 20;
//            quociente = resto / nota;
//            Console.WriteLine(quociente + " nota(s) de " + nota + ",00");
//            resto = resto % nota;

//            nota = 10;
//            quociente = resto / nota;
//            Console.WriteLine(quociente + " nota(s) de " + nota + ",00");
//            resto = resto % nota;

//            nota = 5;
//            quociente = resto / nota;
//            Console.WriteLine(quociente + " nota(s) de " + nota + ",00");
//            resto = resto % nota;

//            nota = 2;
//            quociente = resto / nota;
//            Console.WriteLine(quociente + " nota(s) de " + nota + ",00");
//            resto = resto % nota;

//            Console.WriteLine(resto + " nota(s) de R$1,00");

//        }
//    }
//}

//using System.Globalization;
//using System.Xml;

//namespace beecrowd21
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double N;
//            int nota, moedas, quociente, resto;
//            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            resto = (int)(N * 100.0 + 0.5);

//            Console.WriteLine("MOEDAS:");
//            nota = 100;
//            quociente = resto / (nota * 100);
//            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
//            resto = resto % (nota * 100);

//            nota = 50;
//            quociente = resto / (nota * 100);
//            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
//            resto = resto % (nota * 100);

//            nota = 20;
//            quociente = resto / (nota * 100);
//            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
//            resto = resto % (nota * 100);

//            nota = 10;
//            quociente = resto / (nota * 100);
//            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
//            resto = resto % (nota * 100);

//            nota = 5;
//            quociente = resto / (nota * 100);
//            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
//            resto = resto % (nota * 100);

//            nota = 2;
//            quociente = resto / (nota * 100);
//            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
//            resto = resto % (nota * 100);

//            Console.WriteLine("MOEDAS:");
//            moedas = 100;
//            quociente = resto / moedas;
//            Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
//            resto = resto % moedas;

//            moedas = 50;
//            quociente = resto / moedas;
//            Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
//            resto = resto % moedas;

//            moedas = 25;
//            quociente = resto / moedas;
//            Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
//            resto = resto % moedas;

//            moedas = 10;
//            quociente = resto / moedas;
//            Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
//            resto = resto % moedas;

//            moedas = 5;
//            quociente = resto / moedas;
//            Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
//            resto = resto % moedas;

//            Console.WriteLine(resto + " moeda(s) de R$ 0.01");

//        }

//    }
//}



//using System.ComponentModel.Design;

//class Program
//{
//    static void Main(string[] args)
//    {
//        DateTime agora = DateTime.Now;
//        int HoraAtual = agora.Hour;
//        if (HoraAtual > 18 && HoraAtual > 6)
//        {
//            Console.WriteLine("Boa noite");
//        }
//        else if (HoraAtual > 6 && HoraAtual < 12)
//        {
//            Console.WriteLine("Bom dia");

//        }
//        else if (HoraAtual > 12 && HoraAtual < 18)
//        {
//            Console.WriteLine("Boa tarde");
//        }
//    }
//}


//using System.Globalization;

//namespace aaa
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double p1, p2, média;
//            p1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
//            p2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

//            média = p1 + p2;

//            if (média < 60.00)
//            {
//                Console.WriteLine("Nota final: " + média);
//                Console.WriteLine("Você foi reprovado!");
//            }
//            else
//            {
//                Console.WriteLine("Nota final: " + média);
//                Console.WriteLine("Você foi aprovado!");
//            }
//            Console.ReadKey();
//        }
//    }
//}

//using System.Globalization;
//namespace beecrowd1036
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double a, b, c, delta, r1, r2;
//            string[] vet = Console.ReadLine().Split(' ');
//            a = double.Parse (vet[0],CultureInfo.InvariantCulture);
//            b = double.Parse(vet[1],CultureInfo.InvariantCulture);
//            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

//            delta = Math.Pow(b, 2) - 4 * a * c;
//            if (a == 0 || delta < 0)
//            {
//                Console.WriteLine("Impossivel calcular");
//            }

//            else
//            {
//                r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
//                r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

//                Console.WriteLine("R1 = " + r1.ToString("f5", CultureInfo.InvariantCulture));
//                Console.WriteLine("R2 = " + r2.ToString("f5", CultureInfo.InvariantCulture));
//            }



//        }
//    }
//}

//namespace aleatoria
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int a, b, c;
//            string[] vet = Console.ReadLine().Split(' ');

//            a = int.Parse(vet[0]);
//            b = int.Parse(vet[1]);
//            c = int.Parse(vet[2]);

//            if (a < b && a < c)
//            {
//                Console.WriteLine("MENOR = " + a);
//            }
//            else if (b < c)
//            {
//                Console.WriteLine("MENOR = " + b);
//            }
//            else
//            {
//                Console.WriteLine("MENOR = " + c); //Ctrl + k + d alinha o código
//            }

//        }
//    }
//}

using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;

//namespace switchcase
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int x = int.Parse(Console.ReadLine());
//            string dia;
//            switch (x){
//                case 1:
//                dia="Domingo"; 
//                    break;
//                case 2:
//                    dia="Segunda-Feira";
//                    break;
//                case 3:
//                   dia="Terça-Feira";
//                    break;
//                case 4:
//                    dia="Quarta-Feira";
//                    break;
//                case 5:
//                    dia="Quinta-Feira";
//                    break;
//                case 6:
//                   dia="Sexta-Feira";
//                    break;
//                case 7:
//                    dia="Sábado";
//                    break;
//                default:
//                    dia = "dia inválido";
//                    break;
//            }
//            Console.WriteLine(dia);
//        }
//    }
//}

//namespace beecrowd1035
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int A, B, C, D;
//            string[] vet = Console.ReadLine().Split(' ');
//            A = int.Parse(vet[0]);
//            B = int.Parse(vet[1]);
//            C = int.Parse(vet[2]);
//            D = int.Parse(vet[3]);
//            if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0)
//            {
//                Console.WriteLine("Valores aceitos");
//            }
//            else
//            {
//                Console.WriteLine("Valores nao aceitos");
//            }
//        }
//    }
//}




// - Primeiro grupo (mais básicos): 1035, 1038, 1044, 1046, 1048

//-Segundo grupo: 1037, 1040(use float), 1041, 1045, 1047, 1049, 1051

//Exercícios suplementares:

//-1042, 1043, 1050, 1052, 1060, 1064, 1065, 1066, 1070


//using System.Globalization;
//namespace beecrowd1040
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double codigo, quantidade,valor;
//            string[] vet = Console.ReadLine().Split(' ');
//            codigo = int.Parse(vet[0]);
//            quantidade = int.Parse(vet[1]);

//            if (codigo == 1)
//            {
//                valor = quantidade * 4.00;
//                Console.WriteLine("Total: R$ " + valor.ToString("f2", CultureInfo.InvariantCulture));
//            }
//            else if (codigo == 2)
//            {
//                valor = quantidade * 4.50;
//                Console.WriteLine("Total: R$ " + valor.ToString("f2", CultureInfo.InvariantCulture));
//            }
//            else if (codigo == 3)
//            {
//                valor = quantidade * 5.00;
//                Console.WriteLine("Total: R$ " + valor.ToString("f2", CultureInfo.InvariantCulture));
//            }
//            else if (codigo == 4)
//            {
//                valor = quantidade * 2.00;
//                Console.WriteLine("Total: R$ " + valor.ToString("f2", CultureInfo.InvariantCulture));
//            }
//            else
//            {
//                    valor = quantidade * 1.50;
//                    Console.WriteLine("Total: R$ " + valor.ToString("f2",CultureInfo.InvariantCulture));
//            }
//        }
//    }
//}
//using System.Globalization;
//double a;
//a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//if (a >= 0 && a <= 25)
//{
//    Console.WriteLine("Intervalo [0,25]");
//}
//else if (a >= 25 && a <= 50)
//{
//    Console.WriteLine("Intervalo (25,50]");
//}
//else if (a >= 50 && a <= 75)
//{
//    Console.WriteLine("Intervalo [50,75]");
//}
//else if (a >= 75 && a <= 100)
//{
//    Console.WriteLine("Intervalo (75,100]");
//}
//else
//{
//    Console.WriteLine("Fora de intervalo");
//}

//namespace beecrowd1045
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double n1, n2, n3;
//            string[] vet = Console.ReadLine().Split(' ');
//            n1 = double.Parse(vet[0],CultureInfo.InvariantCulture);
//            n2 = double.Parse(vet[1],CultureInfo.InvariantCulture);
//            n3 = double.Parse(vet[2],CultureInfo.InvariantCulture);

//            double A, B, C;

//            if (n1 > n2 && n1 > n3)
//            {
//                A = n1;
//                if (n2 > n3)
//                {
//                    B = n2;
//                    C = n3;
//                }
//                else
//                {
//                    B = n3;
//                    C = n2;
//                }
//            }
//            else if (n2 > n3)
//            {
//                A = n2;
//                if (n1 > n3)
//                {
//                    B = n1;
//                    C = n3;
//                }
//                else
//                {
//                    B = n3;
//                    C = n1;
//                }
//            }
//            else
//            {
//                A = n3;
//                if (n1 > n2)
//                {
//                    B = n1;
//                    C = n2;
//                }
//                else
//                {
//                    B = n2;
//                    C = n1;
//                }
//            }


//            if (A >= B + C)
//            {
//                Console.WriteLine("NAO FORMA TRIANGULO");
//            }
//            else
//            {

//                if (A * A == B * B + C * C)
//                {
//                    Console.WriteLine("TRIANGULO RETANGULO");
//                }
//                else if (A * A > B * B + C * C)
//                {
//                    Console.WriteLine("TRIANGULO OBTUSANGULO");
//                }
//                else
//                {
//                    Console.WriteLine("TRIANGULO ACUTANGULO");
//                }


//                if (A == B && B == C)
//                {
//                    Console.WriteLine("TRIANGULO EQUILATERO");
//                }
//                else if (A == B || A == C || B == C)
//                {
//                    Console.WriteLine("TRIANGULO ISOSCELES");
//                }
//            }
//        }
//    }
//}

//namespace beecrowd1044
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int A, B;
//            string[] vet = Console.ReadLine().Split(' ');
//            A = int.Parse(vet[0]);
//            B = int.Parse(vet[1]);

//            int n1, n2;
//            if (A > B)
//            {
//                n1 = A;
//                n2 = B;
//            }
//            else
//            {
//                n1 = B;
//                n2 = A;
//            }

//            if (n1 % n2 == 0)
//            {
//                Console.WriteLine("Sao Multiplos");
//            }else
//            {
//                Console.WriteLine("Nao sao Multiplos");
//            }
//        }
//    }
//}

//int inicial, final;
//string[] vet = Console.ReadLine().Split(' ');
//inicial = int.Parse(vet[0]);
//final = int.Parse(vet[1]);

//int total;

//if (inicial < final)
//{
//    total = final - inicial;
//    Console.WriteLine("O JOGO DUROU " + total + " HORA(S)");
//}
//else
//{
//    total = 24 - inicial + final;
//    Console.WriteLine("O JOGO DUROU " + total + " HORA(S)");
//}


//int x, soma;
//x = int.Parse(Console.ReadLine());
//soma = 0;

//while (x != 0)
//{
//    soma += x;
//    x = int.Parse(Console.ReadLine());  
//}
//Console.WriteLine(soma);

//int x, y;
//string[] vet = Console.ReadLine().Split(' ');

//x = int.Parse(vet[0]);
//y = int.Parse(vet[1]);

//while (x != y)
//{
//    if (x > y)
//    {
//        Console.WriteLine("Decrescente");
//    }
//    else
//    {
//        Console.WriteLine("Crescente");
//    }
//    vet = Console.ReadLine().Split(' ');
//    x = int.Parse(vet[0]);
//    y = int.Parse(vet[1]);
//}

//double x, y = 0, soma, contador = 0;
//x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//while (x >= 0)
//{
//    y = y + x;
//    contador++;
//    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//}

//if (contador == 0)
//{
//    Console.WriteLine("impossivel calcular");
//}
//else
//{
//    soma = y / contador;
//    Console.WriteLine(soma.ToString("f2"), CultureInfo.InvariantCulture);
//}


//int senhaInc, senhaCorr = 2002;
//senhaInc = int.Parse(Console.ReadLine());
//while (senhaInc != senhaCorr)
//{
//    Console.WriteLine("Senha Invalida");
//    senhaInc = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("Acesso Permitido");

//int x, y;
//string[] vet = Console.ReadLine().Split(' ');
//x = int.Parse(vet[0]);
//y = int.Parse(vet[1]);
//while (x != 0 && y != 0)
//{
//    if (x > 0 && y > 0)
//    {
//        Console.WriteLine("primeiro");
//    }
//    else if (x < 0 && y > 0)
//    {
//        Console.WriteLine("segundo");
//    }
//    else if (x < 0 && y < 0)
//    {
//        Console.WriteLine("terceiro");
//    }
//    else if (x > 0 && y < 0)
//    {
//        Console.WriteLine("quarto");
//    }
//    vet = Console.ReadLine().Split(' ');
//    x = int.Parse(vet[0]);
//    y = int.Parse(vet[1]);
//}

//double nota1,nota2, media;
//nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

//    while (nota1 < 0 || nota1 > 10)
//    {
//        Console.WriteLine("nota invalida");
//        nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//    }
//nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//while (nota2 < 0 || nota2 > 10)
//{
//    Console.WriteLine("nota invalida");
//    nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//}
//media = (nota1 + nota2) / 2;

//Console.WriteLine("media = "+media.ToString("f2", CultureInfo.InvariantCulture));


//namespace beecrowd1118
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double recome;
//            do
//            {
//                double n1, n2, mediaS;
//                n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                while (n1 > 10 || n1 < 0)
//                {
//                    Console.WriteLine("nota invalida");
//                    n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//                }

//                n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                while (n2 > 10 || n2 < 0)
//                {
//                    Console.WriteLine("nota invalida");
//                    n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                }

//                mediaS = (n1 + n2) / 2;
//                Console.WriteLine("media = " + mediaS.ToString("f2", CultureInfo.InvariantCulture));

//                do
//                {
//                    Console.WriteLine("novo calculo (1-sim 2-nao)");
//                    recome = double.Parse(Console.ReadLine());


//                } while (recome < 1 || recome > 2);
//            } while (recome == 1);
//        }
//    }
//}

//double a,b=0,c;
//a = double.Parse(Console.ReadLine());
//for (int i = 0; i < a; i++)
//{
//    c = double.Parse(Console.ReadLine());
//    b = b + c;
//}
//Console.WriteLine(b);

////1078
//int N, soma,cont;
//N = int.Parse(Console.ReadLine());
//cont = 1;
//for(int i = 0; i < 10; i++)
//{
//    soma = cont * N;
//    Console.WriteLine(cont + " x " + N + " = " + soma);
//    cont++;
//}

//namespace beecrowd1071
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int X, Y, min, max, soma = 0;
//            X = int.Parse(Console.ReadLine());
//            Y = int.Parse(Console.ReadLine());
//            if (X < Y)
//            {
//                min = X;
//                max = Y;
//            }
//            else
//            {
//                max = X;
//                min = Y;
//            }
//            for (int i = min + 1; i < max; i++)
//            {
//                if (i % 2 != 0)
//                {
//                    soma = soma + i;
//                }
//            }
//            Console.WriteLine(soma);
//        }
//    }
//}

//namespace beecrowd1079
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int x;
//            double n1, n2, n3, soma;
//            x = int.Parse(Console.ReadLine());
//            for (int i = 0; i < x; i++)
//            {
//                string[] vet = Console.ReadLine().Split(' ');
//                n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
//                n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
//                n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

//                soma = (n1 * 2 + n2 * 3 + n3 * 5) / 10;
//                Console.WriteLine(soma.ToString("f1", CultureInfo.InvariantCulture));
//            }
//        }
//    }
//}


//namespace beecrowd1067
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int x;
//            x = int.Parse(Console.ReadLine());
//            for (int i = 1; i <= x; i++)
//            {
//                if (i % 2 != 0)
//                {
//                    Console.WriteLine(i);
//                }
//            }
//        }
//    }
//}

//namespace beecrowd1072
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int N, X, dentro = 0, fora = 0;
//            N = int.Parse(Console.ReadLine());
//            if (N < 10000)
//            {
//                for (int i = 0; i < N; i++)
//                {
//                    X = int.Parse(Console.ReadLine());
//                    if (X >= 10 && X <= 20)
//                    {
//                        dentro++;
//                    }
//                    else
//                    {
//                        fora++;

//                    }
//                }
//                Console.WriteLine(dentro + " in");
//                Console.WriteLine(fora + " out");
//            }
//        }
//    }
//}

//namespace beecrowd1073
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int N, soma;
//            N = int.Parse(Console.ReadLine());
//            if (N > 5 && N < 2000)
//            {
//                for (int i = 1; i <= N; i++)
//                {
//                    if (i % 2 == 0)
//                    {
//                        soma = (int)Math.Pow(i, 2);
//                        Console.WriteLine(i + "^2 = " + soma);
//                    }
//                }
//            }
//        }
//    }
//}

//namespace beecrowd1074
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n, x;
//            n = int.Parse(Console.ReadLine());

//            for (int i = 0; i < n; i++)
//            {

//                x = int.Parse(Console.ReadLine());

//                if (x == 0)
//                {
//                    Console.WriteLine("NULL");
//                }
//                else if (x > 0)
//                {
//                    if (x % 2 == 0)
//                    {
//                        Console.WriteLine("EVEN POSITIVE");
//                    }
//                    else
//                    {
//                        Console.WriteLine("ODD POSITIVE");
//                    }
//                }
//                else
//                {
//                    if (x % 2 == 0)
//                    {
//                        Console.WriteLine("EVEN NEGATIVE");
//                    }
//                    else
//                    {
//                        Console.WriteLine("ODD NEGATIVE");
//                    }
//                }
//            }


//        }
//    }
//}


//namespace beecrowd1094
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n, sapo, coelho, rato, total;
//            double ps, pc, pr;


//            n = int.Parse(Console.ReadLine());
//            sapo = 0;
//            coelho = 0;
//            rato = 0;

//            for (int i = 0; i < n; i++)
//            {
//                string[] vet = Console.ReadLine().Split(' ');
//                int quantia = int.Parse(vet[0]);
//                char tipo = char.Parse(vet[1]);

//                if (tipo == 'S')
//                {
//                    sapo = sapo + quantia;
//                }
//                else if (tipo == 'C')
//                {
//                    coelho = coelho + quantia;
//                }
//                else if (tipo == 'R')
//                {
//                    rato = rato + quantia;
//                }
//            }

//            total = sapo + coelho + rato;
//            ps = (double)sapo / total * 100;
//            pc = (double)coelho / total * 100;
//            pr = (double)rato / total * 100;

//            Console.WriteLine("Total: " + total + " cobaias");
//            Console.WriteLine("Total de coelhos: " + coelho);
//            Console.WriteLine("Total de ratos: " + rato);
//            Console.WriteLine("Total de sapos: " + sapo);
//            Console.WriteLine("Percentual de coelhos: " + pc.ToString("f2", CultureInfo.InvariantCulture) + " %");
//            Console.WriteLine("Percentual de ratos: " + pr.ToString("f2", CultureInfo.InvariantCulture) + " %");
//            Console.WriteLine("Percentual de sapos: " + ps.ToString("f2", CultureInfo.InvariantCulture) + " %");
//        }
//    }
//}


//int n;
//double[] vet;

//n = int.Parse(Console.ReadLine());
//vet = new double[n];
//for(int i = 0; i < n; i++)
//{
//    vet[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);  
//}
//for(int i = 0; i < n; i++)
//{
//    Console.WriteLine(vet[i].ToString("f2", CultureInfo.InvariantCulture));
//}

//int N;
//int[] vet;

//N = int.Parse(Console.ReadLine());
//vet = new int[N];

//string[] s = Console.ReadLine().Split(' ');
//for (int i=0;i<N;i++)
//{
//    vet[i] = int.Parse(s[i]);
//}
//for (int i=0;i<N;i++)
//{
//    if (vet[i] < 0)
//    {
//        Console.WriteLine(vet[i]);
//    }
//}



//int n;
//double soma = 0, media, cont = 0;
//double[] x;

//n = int.Parse(Console.ReadLine());
//x = new double[n];


//string[] s = Console.ReadLine().Split(' ');
//for (int i = 0; i < n; i++)
//{
//    x[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
//    soma = soma + x[i];
//    ;
//}
//media = soma / n;
//for (int i = 0; i < n; i++)
//{
//    Console.Write(x[i].ToString("f2", CultureInfo.InvariantCulture) + " ");
//}
//Console.WriteLine();
//Console.WriteLine(soma.ToString("f2", CultureInfo.InvariantCulture));
//Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));



//int n, cont = 0;
//double media, pspessoa;
//string[] nome;
//int[] idade;
//double[] altura;

//n = int.Parse(Console.ReadLine());
//nome = new string[n];
//idade = new int[n];
//altura = new double[n];

////entrada dos dados
//for (int i = 0; i < n; i++)
//{
//    string[] vet = Console.ReadLine().Split(' ');
//    nome[i] = vet[0];
//    idade[i] = int.Parse(vet[1]);
//    altura[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
//}


////calculo da altura media
//double soma = 0;
//for (int i = 0; i < n; i++)
//{
//    soma = soma + altura[i];
//}
//media = soma / n;

////porcentagem de pessoas com menos de 16 anos
//for (int i = 0; i < n; i++)
//{
//    if (idade[i] < 16)
//    {
//        cont++;
//    }
//}
//pspessoa = (double)cont / n * 100;


////saida de dados

//Console.WriteLine("altura media: " + media.ToString("f2", CultureInfo.InvariantCulture));
//Console.WriteLine("Pessoas com menos de 16 anos: "+pspessoa.ToString("f2", CultureInfo.InvariantCulture)+"%");

//namespace aa
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n;
//            n = int.Parse(Console.ReadLine());

//            double[] vet = new double[n];

//            string[] valores = Console.ReadLine().Split(' ');
//            for (int i = 0; i < n; i++)
//            {
//                vet[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
//            }
//            double maior = vet[0];
//            int posicaoMaior = 0;

//            for (int i=1;i<n;i++)
//            {
//                if (vet[0]>maior)
//                {
//                    maior = vet[i];
//                    posicaoMaior = i;
//                }
//            }
//            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
//            Console.WriteLine(posicaoMaior);
//        }
//    }
//}


//namespace vetor2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            //Faça um programa que leia N números inteiros e armazene-os em um vetor.Em seguida, mostre na tela:
//            //  -todos os números pares
//            //  - a quantidade de números pares


//            int N = int.Parse(Console.ReadLine());

//            int[] vet = new int[N];

//            string[] valores = Console.ReadLine().Split(' ');

//            for (int i = 0; i < N; i++)
//            {
//                vet[i] = int.Parse(valores[i]);
//            }

//            // 1: mostrando os numeros pares
//            for (int i = 0; i < N; i++)
//            {
//                if (vet[i] % 2 == 0)
//                {
//                    Console.Write(vet[i] + " ");
//                }
//            }
//            Console.WriteLine();

//            // 2: mostrando a quantidade de pares
//            int quantidadeDePares = 0;
//            for (int i = 0; i < N; i++)
//            {
//                if (vet[i] % 2 == 0)
//                {
//                    quantidadeDePares++;
//                }
//            }
//            Console.WriteLine(quantidadeDePares);
//        }
//    }
//}



//int N;
//string[] nome;
//int[] idade;
//N = int.Parse(Console.ReadLine());
//nome = new string[N];
//idade = new int[N];


//for (int i = 0; i < N; i++)
//{
//    string[] vet = Console.ReadLine().Split(' ');
//    nome[i] = vet[0];
//    idade[i] = int.Parse(vet[1]);
//}

//int maiorIdade = idade[0];
//int posicaoMaiorIdade = 0;

//for (int i = 0; i < N; i++)
//{
//    if (idade[i] > maiorIdade)
//    {
//        maiorIdade = idade[i];
//        posicaoMaiorIdade=i;
//    }
//}
//Console.WriteLine(nome[posicaoMaiorIdade]);
//Console.WriteLine(maiorIdade);





//// Para criar uma MATRIZ vc declara dessa forma
////declaração:
//double[,] A;

////instanciação:
//A = new double[3, 4];    //3 linhas e 4 colunas

////para acessar os elementos de uma matriz é preciso fazer:
//A[1,2] = 10;     //dessa forma o valor 10 será armazenado na linha 1, coluna 2 (linha deitada,coluna em pé)




//int M, N;
//int[,] A;

//string[] s1 = Console.ReadLine().Split(' ');
//M = int.Parse(s1[0]);
//N = int.Parse(s1[1]);
//A = new int[M, N];

////declara os valores
//for (int i = 0; i < M; i++)
//{
//    string[] s = Console.ReadLine().Split(' ');
//    for (int j = 0; j < N; j++)
//    {
//        A[i, j] =int.Parse(s[j]);
//    }
//}

//Console.WriteLine();

////mostra o resultado
//for (int i = 0; i < M; i++)
//{
//    for (int j = 0;j < N; j++)
//    {
//        Console.Write(A[i,j]+" ");
//    }
//    Console.WriteLine();
//}

//int[,] mat;
//int n = 3;
//mat = new int[n,n];
//for(int i = 0; i < n; i++)
//{
//    for(int j = 0; j < n; j++)
//    {
//        mat[i,j] = 1 + i + j;
//    }
//}
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        Console.Write(mat[i, j] + " ");
//    }
//    Console.WriteLine();
//}

int[,] matriz;
int n;
n = int.Parse(Console.ReadLine());
matriz = new int[n, n];
for (int i = 0; i < n; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    for (int j = 0; j < n; j++)
    {
        matriz[i, j] = int.Parse(vet[j]);
    }
}

Console.WriteLine("Diagonal Principal: ");
for (int i = 0; i < n; i++)
{
    Console.Write(matriz[i, i] + " ");
}
Console.WriteLine();

int numerosNegativos = 0;
for (int i = 0; i < n; i++)
{

    for (int j = 0; j < n; j++)
    {
        if (matriz[i, j] < 0)
        {
            numerosNegativos++;
        }
    }
}
Console.WriteLine("Quantidade de Numeros negativos = " + numerosNegativos);
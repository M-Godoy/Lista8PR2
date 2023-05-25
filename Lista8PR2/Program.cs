using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lista8PR2
{
    internal class Program
    {
        public static void Exercício1()
        {
            Console.WriteLine("Aqui será codificado o exercício 1");
            Console.WriteLine("Exercício 1");
            int  i, quant, ti;
            float preco, compra, valort;

            i = 1;
            valort = 0;
            ti = 0;
            do
            {
                Console.WriteLine("digite a quantidade de produtos: ");
                quant = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o preço do produto: ");
                preco = float.Parse(Console.ReadLine());

                ti += quant;
                compra = preco * quant;
                valort += compra;

                Console.WriteLine("Digite '1' para continuar ou '0' para terminar sua compra: ");
                i = int.Parse(Console.ReadLine());

            } while (i != 0) ;

                Console.WriteLine("O total de itens serà igual a : " + ti);
            Console.WriteLine("O valor total da sua compra serà igual a: " + valort);

            Console.ReadKey();
        }
        public static void Exercício2()
        {
            Console.WriteLine("Aqui será codificado o exercício 2");
            Console.WriteLine("Exercício 2");
            int  i , quant;
            float preco, valort, vmaior, vmenor;
            string nome, nmaior = "", nmenor = "";

            vmaior = float.MinValue;
            vmenor = float.MaxValue;
            i = 1;

            do
            {
                Console.WriteLine("Cadastre o nome do produto: ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite a quantidade inserida no estoque desse produto: ");
                quant = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o preço: ");
                preco = float.Parse(Console.ReadLine());

                valort = quant * preco;

                if (valort > vmaior)
                {
                    vmaior = valort;
                    nmaior = nome;
                }
                if (valort < vmenor)
                {
                    vmenor = valort;
                    nmenor = nome;
                }



                Console.WriteLine("digite 0 para sair ou 1 para continuar");
                i = int.Parse(Console.ReadLine());
            } while (i != 0) ;
                Console.WriteLine("O nome do Produto mais caro é: " + nmaior + " com o Valor de: " + vmaior);
            Console.WriteLine("O nome do Produto mais barato é: " + nmenor + " com o Valor de: " + vmenor);
            Console.ReadKey();
        }
        public static void Exercício3()
        {
            Console.WriteLine("Aqui será codificado o exercício 3");
            Console.WriteLine("Exercício 3");

            int  i, nAvaliacao;
            float  pesoNota = 0, pesoT = 0;
        

            i = 1;

            Console.WriteLine("Digite o número de quantas avaliações vc deseja aplicar por bimestre: ");
            nAvaliacao = int.Parse(Console.ReadLine());

            do
            {
                i++;
                Console.WriteLine("Digite o peso da avaliação " + i);
                pesoNota = float.Parse(Console.ReadLine());

                pesoT += pesoNota;
            } while (i <= nAvaliacao);
                if (pesoT < 100)
            {
                Console.WriteLine("soma total dos pesos insuficiente");
            }
            else if (pesoT > 100)
            {
                Console.WriteLine("soma total dos pesos excedente");
            }
            else
            {
                Console.WriteLine("soma total dos pesos adequada");
            }

            Console.ReadKey();

        }
        public static void Exercício4()
        {
            Console.WriteLine("Aqui será codificado o exercício 4");
            Console.WriteLine("Exercício 4");

            int i=1;
            string estado;

            do
            {
                Console.WriteLine("digite a sigla de um estado brasileiro: ");
                estado = Console.ReadLine();

                switch (estado)
                {
                    case "AC":
                        Console.WriteLine("Acre");
                        break;
                    case "AL":
                        Console.WriteLine("Alagoas");
                        break;
                    case "AP":
                        Console.WriteLine("Amapá");
                        break;
                    case "AM":
                        Console.WriteLine("Amazonas");
                        break;
                    case "BA":
                        Console.WriteLine("Bahia");
                        break;
                    case "CE":
                        Console.WriteLine("Ceará");
                        break;
                    case "ES":
                        Console.WriteLine("Espírito Santo");
                        break;
                    case "GO":
                        Console.WriteLine("Goiás");
                        break;
                    case "MA":
                        Console.WriteLine("Maranhão");
                        break;
                    case "MT":
                        Console.WriteLine("Mato Grosso");
                        break;
                    case "MS":
                        Console.WriteLine("Mato Grosso do Sul");
                        break;
                    case "MG":
                        Console.WriteLine("Minas Gerais");
                        break;
                    case "PA":
                        Console.WriteLine("Pará");
                        break;
                    case "PB":
                        Console.WriteLine("Paraíba");
                        break;
                    case "PR":
                        Console.WriteLine("Paraná");
                        break;
                    case "PE":
                        Console.WriteLine("Pernambuco");
                        break;
                    case "PI":
                        Console.WriteLine("Piauí");
                        break;
                    case "RJ":
                        Console.WriteLine("Rio de Janeiro");
                        break;
                    case "RN":
                        Console.WriteLine("Rio Grande do Norte");
                        break;
                    case "RS":
                        Console.WriteLine("Rio Grande do Sul");
                        break;
                    case "RO":
                        Console.WriteLine("Rondônia");
                        break;
                    case "RR":
                        Console.WriteLine("Roraima");
                        break;
                    case "SC":
                        Console.WriteLine("Santa Catarina");
                        break;
                    case "SP":
                        Console.WriteLine("São Paulo");
                        break;
                    case "SE":
                        Console.WriteLine("Sergipe");
                        break;
                    case "TO":
                        Console.WriteLine("Tocantins");
                        break;
                    case "DF":
                        Console.WriteLine("Distrito Federal");
                        break;
                    default:
                        Console.WriteLine("ERRO");
                        break;
                        
                }
               
                Console.WriteLine("Digite 1 para continuar e 0 para parar");
                i=int.Parse(Console.ReadLine());
            } while (i != 0);

            Console.ReadKey();
        }
        public static void Exercício5()
        {
            Console.WriteLine("Aqui será codificado o exercício 5");
            Console.WriteLine("Exercício 5");

            int num, i, dia;

            do
            {
                Console.WriteLine("Digite um Némero inteiro entra 1 e 12, representando um mês doa no: ");
                i = int.Parse(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        Console.WriteLine("Verão");
                        break;
                    case 2:
                        Console.WriteLine("Verão");
                        break;
                    case 3:
                        Console.WriteLine("digite um dia: ");
                        dia = int.Parse(Console.ReadLine());

                        if (dia > 31)
                        {
                            Console.WriteLine("ERRO");
                        }
                        else if (dia < 20)
                        {
                            Console.WriteLine("Verão");
                        }
                        else if (dia >= 20)
                        {
                            Console.WriteLine("Outono");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Outono");
                        break;
                    case 5:
                        Console.WriteLine("Outono");
                        break;
                    case 6:
                        Console.WriteLine("digite um dia: ");
                        dia = int.Parse(Console.ReadLine());

                        if (dia > 30)
                        {
                            Console.WriteLine("ERRO");
                        }
                        else if (dia < 21)
                        {
                            Console.WriteLine("Outono");
                        }
                        else if (dia >= 21)
                        {
                            Console.WriteLine("inverno");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Inverno");
                        break;
                    case 8:
                        Console.WriteLine("Inverno");
                        break;
                    case 9:
                        Console.WriteLine("digite um dia: ");
                        dia = int.Parse(Console.ReadLine());

                        if (dia > 30)
                        {
                            Console.WriteLine("ERRO");
                        }
                        else if (dia < 23)
                        {
                            Console.WriteLine("Inverno");
                        }
                        else if (dia >= 23)
                        {
                            Console.WriteLine("Primavera");
                        }
                        break;
                    case 10:
                        Console.WriteLine("Verão");
                        break;
                    case 11:
                        Console.WriteLine("Verão");
                        break;
                    case 12:
                        Console.WriteLine("digite um dia: ");
                        dia = int.Parse(Console.ReadLine());

                        if (dia > 31)
                        {
                            Console.WriteLine("ERRO");
                        }
                        else if (dia < 22)
                        {
                            Console.WriteLine("Primavera");
                        }
                        else if (dia >= 22)
                        {
                            Console.WriteLine("Verão");
                        }
                        break;
                }
                Console.ReadKey();

                Console.WriteLine("Digite 1 para continuar e 0 para sair ");
              num = int.Parse(Console.ReadLine());    
            }while (num !=0);
        }
        public static void Exercício6()
        {
            Console.WriteLine("Aqui será codificado o exercício 6");
            Console.WriteLine("Exercício 6");

            int i=1;
            float  peso, altura, imc;

            do
            {
                Console.WriteLine("Digite seu peso em Kg: ");
                peso = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite sua altura em metros: ");
                altura = float.Parse(Console.ReadLine());

                imc = peso / (float)Math.Pow(altura, 2);

                if (imc < 18.5)
                {
                    Console.WriteLine("Você está abaixo do peso");
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    Console.WriteLine("Você está com  o peso normal");
                }
                else if (imc > 24.9 && imc <= 29.9)
                {
                    Console.WriteLine("Você está com sobrepeso");
                }
                else if (imc > 29.9 && imc <= 34.9)
                {
                    Console.WriteLine("Você está com obesidade grau 1");
                }
                else if (imc > 34.9 && imc <= 39.9)
                {
                    Console.WriteLine("Você está com obesidade grau 2");
                }
                else if (imc >= 40)
                {
                    Console.WriteLine("Você está com obesidade grau  3 (mórbido)");
                }

                Console.WriteLine("Digite '1' para continuar ou '0' para parar: ");
                i = int.Parse(Console.ReadLine());
            } while (i != 0);
            Console.ReadKey();

        }
        public static void Exercício7()
        {
            Console.WriteLine("Aqui será codificado o exercício 7");
            Console.WriteLine("Exercício 7");

            int  i, n, num=1;

            do
            {
                Console.WriteLine("Digite um Número qualquer: ");
                n = int.Parse(Console.ReadLine());

                i = 1;
                if (n <= 0)
                {
                    Console.WriteLine("ERRO");
                }
                else
                {
                    do
                    {
                        i++;
                        Console.WriteLine("" + i);
                    } while (n % i == 0);
                }

                Console.WriteLine("Digite 1 para continuar e 0 para sair ");
                num = int.Parse(Console.ReadLine());

                Console.ReadKey();
            }while (num!= 0);
        }
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("___Menu___");
                Console.WriteLine("Exercício 1 - digite 1");
                Console.WriteLine("Exercício 2 - digite 2");
                Console.WriteLine("Exercício 3 - digite 3");
                Console.WriteLine("Exercício 4 - digite 4");
                Console.WriteLine("Exercício 5 - digite 5");
                Console.WriteLine("  Para Sair - digite 0");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Agradeço a preferência");
                        break;
                    case 1:
                        Exercício1();
                        break;
                    case 2:
                        Exercício2();
                        break;
                    case 3:
                        Exercício3();
                        break;
                    case 4:
                        Exercício4();
                        break;
                    case 5:
                        Exercício5();
                        break;
                    case 6:
                        Exercício6();
                        break;
                    case 7:
                        Exercício7();
                        break;
                    default:
                        Console.WriteLine("Número Inválido");
                        break;

                }
                Console.ReadKey();
            } while (opcao != 0);

        }
    }
}

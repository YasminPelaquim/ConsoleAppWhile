using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salli = 0;
            int cont = 0;
            string resp1;
            double total = 0;

            Console.WriteLine("Deseja começar? S - sim N - não");
            resp1 = Console.ReadLine();
            while(resp1 == "S")
            {
                Console.WriteLine("Qual a forma de contratação? (A)ssalariado, (C)omissionado, (H)orista ");
                string resp2 = Console.ReadLine();


                switch (resp2)
                {
                    case "A":
                        Console.WriteLine("Qual o valor do salário bruto? ");
                        double salb = double.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o valor de desconto? ");
                        double desc = double.Parse(Console.ReadLine());
                        salli = salb - desc;
                        Console.WriteLine("O valor do salário líquido é de " + salli.ToString("C"));
                        cont++;
                        total += salli;
                        break;

                    case "C":
                        Console.WriteLine("Quantas peças vendeu? ");
                        int pecas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual a comissão por peça? ");
                        double comi = double.Parse(Console.ReadLine());
                        salli = pecas * comi;
                        Console.WriteLine("O valor a ganhar vai ser de " + salli.ToString("C"));
                        cont++;
                        total += salli;
                        break;

                    case "H":
                        Console.WriteLine("Quantas horas trabalhou? ");
                        double horas = double.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o valor por hora? ");
                        double val = double.Parse(Console.ReadLine());
                        salli = horas * val;
                        Console.WriteLine("O valor a ganhar vai ser de " + salli.ToString("C"));
                        cont++;
                        total += salli;
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
                Console.WriteLine("Deseja continuar:  S - sim N - não");
                resp1 = Console.ReadLine();
            }

                Console.WriteLine("A quantidade de funcionários cadastrados foi de " + cont);
                Console.WriteLine("O total da folha de pagamento é de " + total);
                Console.WriteLine("A média de salário é de: " + total / cont);


            Console.ReadKey();
    }
    }
}

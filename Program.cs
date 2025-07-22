using System;
using System.Globalization;

class Program
{
    static void Main()
    {

        double saldo, deposito, saque;
        int menu;

        saldo = 0;

        Console.WriteLine("1 - Depositar dinheiro");
        Console.WriteLine("2 - Sacar dinheiro");
        Console.WriteLine("3 - Ver saldo");
        Console.WriteLine("0 - Encerrar o programa\n");

        menu = int.Parse(Console.ReadLine());
        Console.WriteLine();// pular linha

        while (menu != 0)
        {
            switch (menu)
            {
                case 1:
                    Console.WriteLine("Digite o valor a ser depositado\n");
                    deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();// pular linha
                    saldo = saldo + deposito;
                    Console.WriteLine("Saldo Atual: ");
                    Console.WriteLine("R$ " + saldo.ToString("F2"), CultureInfo.InvariantCulture);
                    break;
                case 2:
                    Console.WriteLine("Informe o valor do Saque: \n");
                    saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine(); // pular linha
                    if (saque <= saldo)
                    {
                        saldo = saldo - saque;
                        Console.WriteLine("Saldo Atual: ");
                        Console.WriteLine("R$ " + saldo.ToString("F2"), CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        Console.WriteLine("Saldo Insuficiente");
                    }
                    break;
                case 3:
                    Console.WriteLine("Saldo da conta\nR$ " + saldo.ToString("F2"));
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
            Console.WriteLine("\n1 - Depositar dinheiro");
            Console.WriteLine("2 - Sacar dinheiro");
            Console.WriteLine("3 - Ver saldo");
            Console.WriteLine("0 - Encerrar o programa\n");

            menu = int.Parse(Console.ReadLine());
            Console.WriteLine();// pular linha

        }





        Console.ReadLine();
    }
}



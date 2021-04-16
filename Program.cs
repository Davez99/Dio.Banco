using System;
using System.Collections.Generic;

namespace DIO.Banco
{
    class Program
    {
        static List<Conta> listConta = new List<Conta>();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        //Listar();
                        break;
                    case "2":
                        //Criar();
                        break;
                    case "3":
                        //Transferir();
                        break;
                    case "4":
                        //Sacar();
                        break;
                    case "5":
                        //Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("   *      *   ");
            Console.WriteLine(" *   *  *   * ");
            Console.WriteLine();
            Console.WriteLine("Obrigado, até a próxima!!!");
            Console.WriteLine();
            Console.WriteLine("   *      *   ");
            Console.WriteLine("      **      ");
        }

        private static void InserirConta()
        {
            Console.WriteLine("Inseria nova conta.");

            Console.WriteLine("Digite tipo da conta:  1 - PF || 2 - PJ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome do cliente: ");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite o saldo: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta, 
                                        saldo: entradaSaldo, credito: entradaCredito,
                                        nome: entradaNome);
            
            listConta.Add(novaConta);

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("**********");
            Console.WriteLine();
            Console.WriteLine("BANCO DIO");
            Console.WriteLine("Para que possamos ajuda-lo, informe a opção desejada:");
            Console.WriteLine(" 1 - Listar Contas. ");
            Console.WriteLine(" 2 - Criar uma nova conta. ");
            Console.WriteLine(" 3 - Transferir. ");
            Console.WriteLine(" 4 - Sacar. ");
            Console.WriteLine(" 5 - Depositar. ");
            Console.WriteLine(" C - Limpar pesquisa. ");
            Console.WriteLine(" X - Sair. ");
            Console.WriteLine();
            Console.WriteLine("**********");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}

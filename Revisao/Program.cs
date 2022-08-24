// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Revisao
{
    public class Program{
        static void Main(String[] arg)
        {
            //Console.WriteLine("Ola Mundo!");

            string opcaoUsuario = obterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {

                switch (opcaoUsuario)
                {

                    case "1":
                        Console.WriteLine("Opção 1");
                        break;
                    case "2":
                        Console.WriteLine("Opção 2");
                        break;
                    case "3":
                        Console.WriteLine("Opção 3");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = obterOpcaoUsuario();
            }


        }

        private static string obterOpcaoUsuario()
        {
            Console.WriteLine("");
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular media geral");
            Console.WriteLine("X - Sair");

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}

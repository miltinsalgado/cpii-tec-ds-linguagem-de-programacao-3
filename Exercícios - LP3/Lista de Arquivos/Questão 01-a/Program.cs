using System;
using System.IO;

namespace Questão_01_a
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = @"C:\Users\milto\Downloads\Desenvolvimento de Sistemas\Linguagem de Programação III\Arquivos Criados - LPIII\professores.txt";
            string Nome = "", Matricula = "", Materia = "", Cadastro = "SIM";
            int cont = 1;

            using (StreamWriter escritor = new StreamWriter(Path))
            {
                while (Cadastro.ToUpper() == "SIM")
                {
                    Console.WriteLine("Entre com o Nome: ");
                    Nome = Console.ReadLine().ToUpper();
                    Console.WriteLine("Entre com a Matrícula:");
                    Matricula = Console.ReadLine().ToUpper();
                    Console.WriteLine("Entre com a Matéria:");
                    Materia = Console.ReadLine().ToUpper();

                    escritor.WriteLine("Professor " + cont + ":");
                    escritor.WriteLine("Nome: " + Nome);
                    escritor.WriteLine("Matrícula: " + Matricula);
                    escritor.WriteLine("Disciplina: " + Materia);
                    escritor.WriteLine("----------------------------------");

                    Console.WriteLine("\nRegistro realizado com sucesso!");
                    Console.WriteLine("\nDeseja inserir um novo professor nos registros?");
                    Cadastro = Console.ReadLine();
                    cont++;

                    Console.WriteLine();
                }
            }
        }
    }
}

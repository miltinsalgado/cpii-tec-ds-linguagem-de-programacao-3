using System;
using System.IO;

namespace Questão_01_b
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = @"C:\Users\milto\Downloads\Desenvolvimento de Sistemas\Linguagem de Programação III\Arquivos Criados - LPIII\professores.txt";
            using (StreamReader leitor = new StreamReader(Path))
            {
                while (!leitor.EndOfStream)
                    Console.WriteLine(leitor.ReadLine());
            }
        }
    }
}

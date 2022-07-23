using System;
using System.IO;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string srcPath = @"C:\Users\milto\Downloads\Desenvolvimento de Sistemas\Linguagem de Programação III\Arquivos Criados - LPIII\origem.txt";
            string destPath = @"C:\Users\milto\Downloads\Desenvolvimento de Sistemas\Linguagem de Programação III\Arquivos Criados - LPIII\destino.txt";

            using (StreamWriter escritor = new StreamWriter(destPath))
            using (StreamReader leitor = new StreamReader(srcPath))
            {
                while (!leitor.EndOfStream)
                {
                    string linha = leitor.ReadLine();
                    escritor.WriteLine(linha);
                }
            }
        }
    }
}

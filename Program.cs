using System;
using System.IO;

namespace arquivocsv
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome,email;
            int idade;
            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o seu email: ");
            email = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            idade = Int16.Parse(Console.ReadLine());


            StreamWriter arquivo = new StreamWriter("dados.csv", true);
            arquivo.WriteLine(nome+";"+email+";"+idade+" anos;"+DateTime.Now.ToShortDateString());

            arquivo.Close();

        }
    }
}

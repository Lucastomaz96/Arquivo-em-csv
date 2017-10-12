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

            FileInfo fi = new FileInfo("dados_cabecalho.csv");
            
            //O ponto de exclamação significa negação, ou seja, diz que tal arquivo "não é".
            
           
            StreamWriter arquivo;
            
            if (fi.Exists){
            arquivo = new StreamWriter("dados_cabecalho.csv", true);
            arquivo.WriteLine(nome+";"+email+";"+idade+" anos;"+DateTime.Now.ToShortDateString());
            }
            else {
            arquivo = new StreamWriter("dados_cabecalho.csv", true);
            arquivo.WriteLine("Nome;Email;Idade;Data de cadastro");
            arquivo.WriteLine(nome+";"+email+";"+idade+" anos;"+DateTime.Now.ToShortDateString());
            }



            arquivo.Close();

        }
    }
}

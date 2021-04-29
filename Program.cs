using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            String nome="";
            DateTime dataNascimento;
            DateTime dataHoje = DateTime.Today;

            Console.WriteLine("Qual seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Olá " + nome + " vamos criar uma senha pra você?");

            Console.WriteLine("Me informe a sua data de nascimento. (dd/mm/aaaa):");
            dataNascimento = DateTime.Parse(Console.ReadLine());

            idade = dataHoje.Year - dataNascimento.Year;

            if ( idade<18 )
                Console.WriteLine("Sua senha é: " + nome + idade);
            
            else
                Console.WriteLine("A sua senha é: " + idade + nome);

        }
    }
}

using System;
using System.Globalization;

namespace ConsoleEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1

            int A, B, soma;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            soma = A + B;

            Console.WriteLine("SOMA= " + soma);

            //Exercício 2

            double R, Area, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Area = pi * R * R;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));

            //Exercício 3

            int numero, horas;

            double valorHora, salario;

            numero = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());

            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horas;

            Console.WriteLine("NUMBER= " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));


            //Exercício 4

            double senha = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (senha != 2002)
            {
                Console.WriteLine("Senha Inválida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");

            //Exercício 5

            int x = int.Parse(Console.ReadLine());


            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            //Exercício 6

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira Pessoa: ");
            Console.WriteLine("Nome: ");

            p1.Nome = Console.ReadLine();

            Console.WriteLine("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados da Segunda Pessoa: ");
            Console.WriteLine("Nome: ");

            p2.Nome = Console.ReadLine();

            Console.WriteLine("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
                Console.WriteLine("Pessoa mais velha: " + p1);
            else
                Console.WriteLine("Pessoa mais velha: " + p2);

            //Exercício 7

            Funionario f1 = new Funionario();
            Funionario f2 = new Funionario();

            Console.WriteLine("Dados da primeira Funcionario: ");
            Console.WriteLine("Nome: ");

            f1.Nome = Console.ReadLine();

            Console.WriteLine("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Dados da Segunda Funcionario: ");
            Console.WriteLine("Nome: ");

            f2.Nome = Console.ReadLine();

            Console.WriteLine("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

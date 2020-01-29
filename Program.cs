using System;
using System.Globalization;
using System.Collections.Generic;

namespace Couse
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] line = Console.ReadLine().Split(' ');

            int m = int.Parse(line[0]);

            int n = int.Parse(line[1]);



            int[,] mat = new int[m, n];



            for (int i = 0; i < m; i++)
            {

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {

                    mat[i, j] = int.Parse(values[j]);

                }

            }



            int x = int.Parse(Console.ReadLine());



            for (int i = 0; i < m; i++)
            {

                for (int j = 0; j < n; j++)
                {

                    if (mat[i, j] == x)
                    {

                        Console.WriteLine("Position " + i + "," + j + ":");

                        if (j > 0)
                        {

                            Console.WriteLine("Left: " + mat[i, j - 1]);

                        }

                        if (i > 0)
                        {

                            Console.WriteLine("Up: " + mat[i - 1, j]);

                        }

                        if (j < n - 1)
                        {

                            Console.WriteLine("Right: " + mat[i, j + 1]);

                        }

                        if (i < m - 1)
                        {

                            Console.WriteLine("Down: " + mat[i + 1, j]);

                        }

                    }

                }

            }

            /*
            List<Employee> emp = new List<Employee>();
            Console.Write("How many employees will be registered? ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i < qtd; i++)
            {
                Console.WriteLine("Emplyoee #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.Add(new Employee(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idEmp = int.Parse(Console.ReadLine());
            Console.Write("Enter the percentage: ");
            double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 1; i < emp.Count; i++)
            {
                if (idEmp == emp[i].Id)
                {
                    emp[i].IncreaseSalary(percent);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in emp)
            {
                Console.WriteLine(emp);
            }

            /*
            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double valorAComprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorAPagar = ConversorDeMoeda.Converte(dolar, valorAComprar);
            Console.WriteLine("Valor a ser pago em Reais = " + valorAPagar.ToString("F2", CultureInfo.InvariantCulture));
            */
        }
    }
}

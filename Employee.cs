using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Couse
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string nome, double salario)
        {
            Id = id;
            Name = nome;
            Salary = salario;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * (percentage / 100.0);
        }

        public override string ToString()
        {

            return Id

                + ", "

                + Name

                + ", "

                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}

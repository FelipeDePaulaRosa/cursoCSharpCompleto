using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListas
{
    class Employee
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public double Salario { get; set; }
        
        public Employee(int id, String nome, double salario)
        {
            this.Id = id;
            this.Nome = nome;
            this.Salario = salario;
        }

        public double AumentarSalario(double perc)
        {
            return Salario += Salario * perc / 100;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}

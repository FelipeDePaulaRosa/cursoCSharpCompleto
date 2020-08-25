using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClassesMetodosAbstratos.Entities
{
    abstract class Pessoa
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Pessoa(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        abstract public double Tax();
    }
}

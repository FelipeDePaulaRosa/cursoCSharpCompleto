using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClassesMetodosAbstratos.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int NumberEmployees { get; set; }

        public PessoaJuridica(string name, double anualIncome, int numberEmployees) : base (name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double Tax()
        {
            if (NumberEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}

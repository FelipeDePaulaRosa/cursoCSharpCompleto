using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetores
{
    class Estudante
    {
        public String Nome { get; set; }
        public String Email { get; set; }

        public Estudante(String nome, String email)
        {
            this.Nome = nome;
            this.Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}

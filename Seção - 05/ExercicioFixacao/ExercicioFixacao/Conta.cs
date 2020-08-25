using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao
{
    class Conta
    {
        private String Nome { get; set; }
        public int numeroConta { get; private set; }
        public double Saldo { get; private set; }

        public Conta(){
        }

        public Conta(int numero, string nome)
        {
            numeroConta = numero;
            Nome = nome;
        }

        public Conta(int numero, string nome, double saldo) : this(numero, nome)
        {
            Saldo = saldo;
        }

        public double Depositar(double quantia)
        {
            return Saldo += quantia; 
        }
        public double Sacar(double quantia)
        {

            return Saldo -= quantia + 5;
        }

        public override string ToString()
        {
            return "Conta " + numeroConta + ", Titular " + Nome + ", Saldo: $ " + Saldo;
        }

    }
}

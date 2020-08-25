using System;
using System.Collections.Generic;

namespace ExercicioInterface.Entities
{
    public class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>(); //toda vez que for chamado o construtor do contrato ira instanciar a nova lista de Installmente
        }
        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}

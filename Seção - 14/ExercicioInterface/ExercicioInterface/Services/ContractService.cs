using System;
using System.Collections.Generic;
using ExercicioInterface.Entities;


namespace ExercicioInterface.Services
{
    class ContractService
    {

        private IOnlinePaymentService _onlinePaymentService; //Cria um objeto do tipo da interface que ira ser usada para a inversao de controle

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}


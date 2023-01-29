using Interfaces.Entities.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    class ContractService : IContractService
    {
        private IOnlinePaymentService _onlinePaymentService; 
        public ContractService(IOnlinePaymentService paymentService) {
            _onlinePaymentService = paymentService;
        }

        public void ProcessPayment(Contract contract, int numInstallments)
        {
            var basicQuota = contract.TotalValue / numInstallments;
            for (int i = 1; i <= numInstallments; i++)
            {
                DateTime dateToPay = contract.Date.AddMonths(i);
                double valueQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = valueQuota + _onlinePaymentService.PaymentFee(valueQuota);

                contract.Installments.Add(new Installment(dateToPay, fullQuota));
            }
        }
    }
}

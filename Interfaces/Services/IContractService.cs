using Interfaces.Entities.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    interface IContractService
    {
        void ProcessPayment(Contract contract, int numInstallments);
    }
}

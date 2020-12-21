using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatura_ödeme.Repositories.Interfaces
{
    public interface IBaseInvoiceRepositories
    {
        void Pay(double sonuc);
    }
}

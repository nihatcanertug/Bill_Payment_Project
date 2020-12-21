using Fatura_ödeme.Entities.Abstracts;
using Fatura_ödeme.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatura_ödeme.Entities.Concreate
{
    public class Water : BaseInvoice, IBaseInvoiceRepositories
    {
        const double WaterConstant = 0.65;
        const double Kdv = 0.18;
        public void Pay(double amount)
        {
            total = WaterConstant * amount * Kdv;
            MessageBox.Show($"Water Bill : {total}");
          
        }
    }
}

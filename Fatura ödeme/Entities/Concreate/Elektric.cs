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
    public class Elektric : BaseInvoice, IBaseInvoiceRepositories
    {
        const double ElectricConstant = 0.35;
        const double Kdv = 0.18;


        public void Pay(double amount)
        {

           total = amount * ElectricConstant * Kdv;
            MessageBox.Show($"Electricity bill: {total}");

        }
    }
}

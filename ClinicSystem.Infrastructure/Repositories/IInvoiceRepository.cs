using ClinicSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Infrastructure.Repositories
{
    public interface IInvoiceRepository : IRepository<Invoice>
    {
        Task<IEnumerable<Invoice>> GetUnpaidInvoicesAsync();
        Task<Invoice?> GetInvoiceWithTransactionsAsynce(int invoiceId);
    }
}

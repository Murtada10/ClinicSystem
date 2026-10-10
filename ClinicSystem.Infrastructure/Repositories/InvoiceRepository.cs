using ClinicSystem.Core.Entities;
using ClinicSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicSystem.Infrastructure.Repositories
{
    public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Invoice>> GetUnpaidInvoicesAsync()
        {
            // Filters for all outstanding balances
            return await _dbSet
                .Where(i => i.Balance > 0)
                .ToListAsync();
        }

        public async Task<Invoice?> GetInvoiceWithTransactionsAsynce(int invoiceId)
        {
            // Eagerly loads payment receipts associated with this invoice
            return await _dbSet
                .Include(i => i.PaymentTransactions)
                .FirstOrDefaultAsync(i => i.Id == invoiceId);
        }
    }
}

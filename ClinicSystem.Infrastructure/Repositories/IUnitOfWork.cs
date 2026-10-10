using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Infrastructure.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> CompleteAsync();
    }
}

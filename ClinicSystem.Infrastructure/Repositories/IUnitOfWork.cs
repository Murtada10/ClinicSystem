using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> CompleteAsync();
    }
}

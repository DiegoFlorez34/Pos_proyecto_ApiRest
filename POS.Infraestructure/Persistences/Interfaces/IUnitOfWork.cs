using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infraestructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
       //declaracion o matricula de nuestras interfaces a nivel de repositorio
       ICategoryRepository Category { get; }
        IUserRepository User { get; }
        IProviderRepository Provider { get; }
        void SaveChange();
        Task SaveChangeAsync();

    }
}

using POS.Domain.Entities;
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
        IGenericRepository<Category> Category {get; }
        IGenericRepository<Provider> Provider { get; }
        IGenericRepository<DocumentType> DocumentType { get; }

        IUserRepository User { get; }
        void SaveChange();
        Task SaveChangeAsync();

    }
}

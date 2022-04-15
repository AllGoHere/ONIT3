using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Laba4._5.Storage.Entity;

namespace Laba4._5.Managers.Clients
{
    public interface IClientsManager
    {
        Task<Client> AddClient(CreateOrUpdateClients request);
        Task<IReadOnlyCollection<Client>> GetAll();
        Task<Client> EditClient(Guid Id, CreateOrUpdateClients request);
        Task<Client> GetById(Guid Id);
        Task<Client> Delete(Client entity);
    }
}
 
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Laba4._5.Storage.Entity;

namespace Laba4._5.Managers.Personals
{

    public interface IPersonalsManager
    {
        Task<Personal> AddPersonal(CreateOrUpdatePersonals request);
        Task<Personal> EditPersonal(Guid Id, CreateOrUpdatePersonals request);
        Task<Personal> GetById(Guid Id);
        Task<Personal> Delete(Personal entity);
        Task<IReadOnlyCollection<Personal>> GetAll();
    }
}

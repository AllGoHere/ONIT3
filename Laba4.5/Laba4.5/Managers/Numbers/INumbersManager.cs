using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Laba4._5.Storage.Entity;

namespace Laba4._5.Managers.Numbers
{
    public interface INumbersManager
    {
        Task<Number> AddNumber(CreateOrUpdateNumbers request);
        Task<IReadOnlyCollection<Number>> GetAll();
        Task<Number> Delete(Number entity);
        Task<Number> GetById(Guid Id);
        Task<Number> EditNumber(Guid Id, CreateOrUpdateNumbers request);

    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Laba4._5.Storage.Entity;

namespace Laba4._5.Managers.CHnumbers
{
    public interface ICHnumbersManager
    {
        Task<CHnumber> AddCHnumber(CreateOrUpdateCHnumbers request);
        Task<IReadOnlyCollection<CHnumber>> GetAll();
        Task<CHnumber> EditCHnumber(Guid Id, CreateOrUpdateCHnumbers request);
        Task<CHnumber> GetById(Guid Id);
        Task<CHnumber> Delete(CHnumber entity);

    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Laba4._5.Storage.Entity;

namespace Laba4._5.Managers.Hotels
{
    public interface IHotelsManager
    {
        Task<Hotel> Delete(Hotel entity);
        Task<Hotel> EditHotel(Guid Id, CreateOrUpdateHotels request);
        Task<IReadOnlyCollection<Hotel>> GetAll();
        Task<Hotel> AddHotel(CreateOrUpdateHotels request);
        Task<Hotel> GetById(Guid Id);



    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Laba4._5.Storage;
using Laba4._5.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace Laba4._5.Managers.Hotels
{
    public class HotelsManager : IHotelsManager
    {
        private readonly HotelDataContext _dbContext;

        public HotelsManager(HotelDataContext dbContext)
        {
            _dbContext = dbContext;

        }

        public async Task<Hotel>AddHotel(CreateOrUpdateHotels request)
        {
            var entity = new Hotel
            {
                Id = Guid.NewGuid(),
                floors = request.floors,
                KolNum = request.KolNum,
                name = request.name,
                kolsot = request.kolsot
            };
            _dbContext.Hotels.Add(entity);
            await _dbContext.SaveChangesAsync();

            return entity;

        }

        public async Task<IReadOnlyCollection<Hotel>> GetAll()
        {
            var query = _dbContext.Hotels;
                                  
            var entityes = await query.ToListAsync();

            return entityes;

        }
        public async Task<Hotel> EditHotel(Guid Id, CreateOrUpdateHotels request)
        {
            var entity = await _dbContext.Hotels.FirstOrDefaultAsync(i => i.Id == Id);
            entity.floors = request.floors;
            entity.KolNum = request.KolNum;
            entity.name = request.name;
            entity.kolsot = request.kolsot;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        public async Task<Hotel> GetById(Guid Id)
        {
            return await _dbContext.Hotels.FirstOrDefaultAsync(i => i.Id == Id);
        }
        public async Task<Hotel> Delete(Hotel entity)
        {
            _dbContext.Hotels.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}

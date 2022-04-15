using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laba4._5.Storage;
using Laba4._5.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace Laba4._5.Managers.CHnumbers
{
    public class CHnumbersManager:ICHnumbersManager
    {
        private readonly HotelDataContext _dbContext;

        public CHnumbersManager(HotelDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task <CHnumber> AddCHnumber(CreateOrUpdateCHnumbers request)
        {
            var entity = new CHnumber

            {
                Id = Guid.NewGuid(),
                rooms = request.rooms,
                sleep = request.sleep,
                HotelId = request.HotelId
            };

            _dbContext.CHnumbers.Add(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<IReadOnlyCollection<CHnumber>> GetAll()
        {
            var query = _dbContext.CHnumbers
                                  .OrderBy(cnum => cnum.sleep)
                                  .AsNoTracking();
            var entityes = await query.ToListAsync();

            return entityes;

        }
        public async Task<CHnumber> EditCHnumber(Guid Id, CreateOrUpdateCHnumbers request)
        {
            var entity = await _dbContext.CHnumbers.FirstOrDefaultAsync(i => i.Id == Id);
            entity.sleep = request.sleep;
            entity.rooms = request.rooms;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        public async Task<CHnumber> GetById(Guid Id)
        {
            return await _dbContext.CHnumbers.FirstOrDefaultAsync(i => i.Id == Id);
        }
        public async Task<CHnumber> Delete(CHnumber entity)
        {
            _dbContext.CHnumbers.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}

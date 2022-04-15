using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Linq;
using Laba4._5.Storage;
using Laba4._5.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace Laba4._5.Managers.Numbers
{
    public class NumbersManager : INumbersManager
    {
        private readonly HotelDataContext _dbContext;
        public NumbersManager(HotelDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Number> AddNumber(CreateOrUpdateNumbers request)

        {
            var entity = new Number

            {
            Id = Guid.NewGuid(),
            floor = request.floor,
            nomer = request.nomer,
            CHNumberId = request.CHNumberId
            };

            _dbContext.Numbers.Add(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

     

        public async Task<IReadOnlyCollection<Number>> GetAll()
        {
            var query = _dbContext.Numbers
                                  .OrderBy(num => num.floor)
                                  .AsNoTracking();
            var entityes = await query.ToListAsync();

            return entityes;

        }

        public async Task<Number> EditNumber(Guid Id, CreateOrUpdateNumbers request)
        {
            var entity = await _dbContext.Numbers.FirstOrDefaultAsync(i => i.Id == Id);
            entity.nomer = request.nomer;
            entity.floor = request.floor;
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Number> GetById(Guid Id)
        {
            return await _dbContext.Numbers.FirstOrDefaultAsync(i => i.Id == Id);
        }
        public async Task<Number> Delete(Number entity)
        {
            _dbContext.Numbers.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}

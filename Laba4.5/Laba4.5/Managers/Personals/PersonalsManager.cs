using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laba4._5.Storage;
using Laba4._5.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace Laba4._5.Managers.Personals
{
    public class PersonalsManager : IPersonalsManager
    {
        private readonly HotelDataContext _dbContext;
        public PersonalsManager(HotelDataContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Personal> AddPersonal (CreateOrUpdatePersonals request)
        {
            var entity = new Personal
            {
                Id = Guid.NewGuid(),
                name = request.name,
                lastname = request.lastname,
                dolzhnost = request.dolzhnost,
                HotelId = request.HotelId
            };
            _dbContext.Personals.Add(entity);
            await _dbContext.SaveChangesAsync();

            return entity;

        }

        public async Task<IReadOnlyCollection<Personal>> GetAll()
        {
            var query = _dbContext.Personals
                                  .OrderBy(per => per.dolzhnost)
                                  .AsNoTracking();
            var entityes = await query.ToListAsync();

            return entityes;

        }

        public async Task<Personal> EditPersonal(Guid Id, CreateOrUpdatePersonals request)
        {
            var entity = await _dbContext.Personals.FirstOrDefaultAsync(i => i.Id == Id);
            entity.name = request.name;
            entity.lastname = request.lastname;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        public async Task<Personal> GetById(Guid Id)
        {
            return await _dbContext.Personals.FirstOrDefaultAsync(i => i.Id == Id);
        }
        public async Task<Personal> Delete(Personal entity)
        {
            _dbContext.Personals.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }














    }
}

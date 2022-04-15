using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Laba4._5.Storage;
using Laba4._5.Storage.Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace Laba4._5.Managers.Clients
{
    public class ClientsManager : IClientsManager
    {
        private readonly HotelDataContext _dbContext;
        private readonly IWebHostEnvironment _hostEnvironment;

        

        public ClientsManager (HotelDataContext dbContext, IWebHostEnvironment hostEnvironment)

        {
            _dbContext = dbContext;
            _hostEnvironment = hostEnvironment;
        }


        public async Task <Client> AddClient(CreateOrUpdateClients request)

        {
            var entity = new Client
            {
                Id = Guid.NewGuid(),
                number = request.number,
                name = request.name,
                lastname = request.lastname,
                nights = request.nights,
                NumberId = request.NumberId
            };
            _dbContext.Clients.Add(entity);

            await _dbContext.SaveChangesAsync();
            return entity;

        }

        public async Task<IReadOnlyCollection <Client>> GetAll()
        {
            var query = _dbContext.Clients
                                  .Include(cl => cl.Number)
                                  .OrderBy(cl => cl.lastname)
                                  .AsNoTracking();
            var entityes = await query.ToListAsync();

            return entityes;

        }

        public async Task <Client> EditClient(Guid Id,CreateOrUpdateClients request)
        {
            var entity = await _dbContext.Clients.FirstOrDefaultAsync(i => i.Id == Id);
            entity.name = request.name;
            entity.lastname = request.lastname;
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Client> GetById(Guid Id)
        {
            return await _dbContext.Clients.FirstOrDefaultAsync(i => i.Id == Id);
        }
        public async Task<Client> Delete(Client entity)
        {
            _dbContext.Clients.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

    }
}

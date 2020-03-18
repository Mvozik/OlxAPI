using Microsoft.EntityFrameworkCore;
using OLX.Data;
using OLX.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLX.Repo
{
    public class AdvertRepo : IAdvertRepo
    {
        private readonly DataContext _context;
        public AdvertRepo(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> AddAdvert(Advert advert)
        {
            if (advert.Name == null && advert.Price == 0)
            { return false; }
            else
            {
                advert.Id = Guid.NewGuid();
                await _context.Adverts.AddAsync(advert);
                await _context.SaveChangesAsync();
                return true;
            }
            
        }

        public async Task<bool> DeleteAdvert(Guid Id)
        {
            var Advert = await _context.Adverts.FirstOrDefaultAsync(u => u.Id == Id);
            if(Advert==null)
                return false;
            else
            _context.Adverts.Remove(Advert);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Advert> GetAdvert(Guid Id)
        {
            var Advert = await _context.Adverts.FirstOrDefaultAsync(u => u.Id == Id);
            
            return Advert;
        }

        public async Task<List<Advert>> GetAdverts()
        {
            var adverts = await _context.Adverts.ToListAsync();
            return adverts;
        }

        public async Task<bool> UpdateAdvert(Advert advert)
        {
            _context.Adverts.Update(advert);
            var result = await _context.SaveChangesAsync();
            return result > 0;

        }

     
    }
}

using OLX.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLX.Repo
{
    public interface IAdvertRepo
    {
        Task<List<Advert>> GetAdverts();
        Task<Advert> GetAdvert(Guid Id);
        Task<bool> DeleteAdvert(Guid Id);
        Task<bool> UpdateAdvert(Advert advert);
        Task<bool> AddAdvert(Advert advert);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OLX.Data;
using OLX.Domain;
using OLX.Repo;
using OLX.Routes;

namespace OLX.Controllers
{
    [ApiController]
    public class AdvertController : ControllerBase
    {
        private readonly IAdvertRepo _repo;
        public AdvertController(IAdvertRepo repo)
        {
            _repo = repo;
        }

        [HttpGet(ApiRoutes.Posts.Get)]
        public async Task<IActionResult> GetAdvert([FromRoute]Guid AdvertId)
        {
            var respons = await _repo.GetAdvert(AdvertId);
            if (respons == null)
                return NotFound();

            return Ok(respons);
        }

        [HttpPost(ApiRoutes.Posts.PostAdvert)]
        public async Task<IActionResult> AddAdvert([FromBody]Advert advert)
        {
            var respons = await _repo.AddAdvert(advert);
            if (respons == false)
                return NotFound();
            else
            {
                var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
                var locationUri = baseUrl + "/" + ApiRoutes.Posts.Get.Replace("{AdvertId}", advert.Id.ToString());
                return Created(locationUri, advert);
            }
    
        }
        [HttpDelete(ApiRoutes.Posts.DeleteAdvert)]
        public async Task<IActionResult> DeleteAdvert([FromRoute]Guid AdvertId)
        {
            var respons = await _repo.DeleteAdvert(AdvertId);
            if (respons == false)
                return NotFound();
            return Ok();

        }
        [HttpPut(ApiRoutes.Posts.UpdateAdvert)]
        public async Task<IActionResult> UpdateAdvert([FromBody]Advert advert)
        {
            var respons = await _repo.UpdateAdvert(advert);
            if (respons == false)
                return NotFound();
            return Ok();
        }

        [HttpGet(ApiRoutes.Posts.GetAdverts)]
        public async Task<IActionResult> GetAdverts()
        {
            var respons = await _repo.GetAdverts();
            if(respons == null)
                return NotFound();

            return Ok(respons);
        }



    }
}
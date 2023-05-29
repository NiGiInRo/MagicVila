using MagicVila_API.Data;
using MagicVila_API.Models;
using MagicVila_API.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicVila_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDto> GetVillas()
        {
            return VillaStore.villaList;
        }

        [HttpGet("id")]
        public VillaDto GetVilla(int id)
        {
            return VillaStore.villaList.FirstOrDefault(v => v.Id == id);
        }
    }
}

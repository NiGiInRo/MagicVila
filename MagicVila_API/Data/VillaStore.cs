using MagicVila_API.Models.Dto;

namespace MagicVila_API.Data
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto { Id=1, Name="Pisicina"},
            new VillaDto { Id = 2, Name = "Playa" },
            new VillaDto { Id = 3, Name = "Baiha" }
        };
    }
}

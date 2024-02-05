using Backend.DTOs;

namespace Backend.Services
{
    public interface IBeerService
    {
        Task<IEnumerable<BeerDto>> Get();
        Task<BeerDto> GetById(int id);
        Task<BeerDto> Add(BeerInsertDto beerInsertDto);
        Task<BeerDto> Update(int id, BeerUpdateDto beerUpdateDto);
        Task<BeerDto> Delete(int id);
    }
}

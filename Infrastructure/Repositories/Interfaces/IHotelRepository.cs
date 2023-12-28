using Domain.AggregatesModel;

namespace Infrastructure.Repositories.Interfaces;

public interface IHotelRepository
{
    Task<int> CreateHotel(HotelModel hotel);
    bool UpdateHotel(HotelModel hotel);
    Task<HotelModel> GetHotelById(int id);
    Task<List<HotelModel>> GetAllHotelsByCountry(string country);

}

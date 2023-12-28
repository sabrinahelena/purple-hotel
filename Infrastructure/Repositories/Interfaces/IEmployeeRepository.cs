using Domain.AggregatesModel;

namespace Infrastructure.Repositories.Interfaces;

public interface IEmployeeRepository
{
    Task<int> CreateEmployee(EmployeeModel employee);
    bool UpdateEmployee(EmployeeModel employee);
    Task<EmployeeModel> GetEmployeeById(int id);
    Task<List<EmployeeModel>> GetAllEmployeesByHotelId(int hotelId);
    Task<List<EmployeeModel>> GetAllEmployeesByPosition(int position);
}

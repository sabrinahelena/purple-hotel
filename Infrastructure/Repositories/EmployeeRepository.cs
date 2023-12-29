using Domain.AggregatesModel;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    protected readonly PurpleHotelContext _context;
    public EmployeeRepository(PurpleHotelContext context)
    {
        this._context = context;
    }
    public async Task<int> CreateEmployee(EmployeeModel employee)
    {
        await _context.Employee.AddAsync(employee);
        _context.SaveChanges();
        return employee.Id;
    }

    public async Task<List<EmployeeModel>> GetAllEmployeesByHotelId(int hotelId)
    {
        return await _context.Employee.Where(x => x.HotelId == hotelId).ToListAsync();
    }

    public async Task<List<EmployeeModel>> GetAllEmployeesByPosition(int position)
    {
        return await _context.Employee.Where(x => x.Position == position).ToListAsync();
    }

    public async Task<EmployeeModel> GetEmployeeById(int id)
    {
        return await _context.Employee.FirstOrDefaultAsync(x => x.Id == id);
    }

    public bool UpdateEmployee(EmployeeModel employee)
    {
        _context.Update(employee);
        _context.SaveChanges();
        return true;
    }
}

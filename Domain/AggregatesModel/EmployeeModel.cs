namespace Domain.AggregatesModel;

public class EmployeeModel
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string LastName { get; init; } = string.Empty;
    public int Position { get; init; }
    public DateTime HiringDate { get; init; }
    public string Contact { get; init; } = string.Empty;
    public string Phone { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public double Salary { get; init; }
    public int? WorkingHours { get; init; }
    public int HotelId { get; init; }
}

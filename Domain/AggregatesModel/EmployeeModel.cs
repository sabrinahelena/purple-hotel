namespace Domain.AggregatesModel;

public class EmployeeModel
{
    public int Id { get; init; }
    public string Name { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public int Position { get; private set; }
    public DateTime HiringDate { get; private set; }
    public string Contact { get; private set; } = string.Empty;
    public string Phone { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public double Salary { get; private set; }
    public int? WorkingHours { get; private set; }
    public int HotelId { get; private set; }
}

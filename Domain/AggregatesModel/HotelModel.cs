namespace Domain.AggregatesModel;

public class HotelModel
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public int StarsQuantity { get; init; }
    public DateTime? FoundedIn { get; init; }
    public string ZipCode { get; init; } = string.Empty;
    public string Street { get; init; } = string.Empty;
    public string Neighbourhood { get; init; } = string.Empty;
    public int AddressNumber { get; init; }
    public string City { get; init; } = string.Empty;
    public string State { get; init; } = string.Empty;
    public string Country { get; init; } = string.Empty;
    public int AvailableRooms { get; init; }
    public string Description { get; init; } = string.Empty;
    public List<EmployeeModel> Employees { get; init; } = new();
    public List<RoomModel> Rooms { get; init; } = new();

}

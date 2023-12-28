namespace Domain.AggregatesModel;

public class HotelModel
{
    public int Id { get; init; }
    public string Name { get; private set; } = string.Empty;
    public int StarsQuantity { get; private set; }
    public DateTime? FoundedIn { get; private set; }
    public string ZipCode { get; private set; } = string.Empty;
    public string Street { get; private set; } = string.Empty;
    public string Neighbourhood { get; private set; } = string.Empty;
    public int AddressNumber { get; private set; }
    public string City { get; private set; } = string.Empty;
    public string State { get; private set; } = string.Empty;
    public string Country { get; private set; } = string.Empty;
    public int AvailableRooms { get; private set; }
    public string Description { get; private set; } = string.Empty;
    public List<EmployeeModel> Employees { get; init; } = new();
    public List<RoomModel> Rooms { get; init; } = new();

}

namespace Domain.AggregatesModel
{
    public class GuestModel
    {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public string LastName { get; init; } = string.Empty;
        public string CPF { get; init; } = string.Empty;
        public string DocumentNumber { get; init; } = string.Empty;
        public string Contact { get; init; } = string.Empty;
        public string Phone { get; init; } = string.Empty;
        public string Email { get; init; } = string.Empty;
        public DateTime BirthDate { get; init; }
        public string Nationality { get; init; } = string.Empty;
        public int ReservationId { get; set; }
        public ReservationModel Reservation { get; init; }
    }
}

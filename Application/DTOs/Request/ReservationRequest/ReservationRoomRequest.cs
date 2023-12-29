namespace Application.DTOs.Request.ReservationRequest
{
    public class ReservationRoomRequest
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public int Number { get; set; }
    }
}

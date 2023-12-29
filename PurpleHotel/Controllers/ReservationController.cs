using Application.DTOs.Request.ReservationRequest;
using Application.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace PurpleHotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }


        [HttpPost("post")]
        public IActionResult AddReservation([FromBody] ReservationRequest newReservationRequest)
        {
            var brand = _reservationService.CreateReservationAsync(newReservationRequest);
            return Ok(new { Status = "Created", brand.Id });
        }

    }
}

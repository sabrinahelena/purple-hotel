using Application.DTOs.Request.ReservationRequest;
using Application.DTOs.Response;
using Application.Mapper;
using Application.Services.Interface;
using Domain.Interfaces;

namespace Application.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;

        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<CreateResponse> CreateReservationAsync(ReservationRequest request, CancellationToken cToken = default)
        {
            var model = ReservationMapper.Map(request);
            var reservationCreated = _reservationRepository.CreateReservation(model, cToken);
            return new CreateResponse
            {
                Id = reservationCreated.Id,
                Success = true
            };
        }
    }
}

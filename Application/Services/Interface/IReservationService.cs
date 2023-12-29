using Application.DTOs.Request.ReservationRequest;
using Application.DTOs.Response;

namespace Application.Services.Interface
{
    public interface IReservationService
    {
        Task<CreateResponse> CreateReservationAsync(ReservationRequest request, CancellationToken cToken = default);
    }
}

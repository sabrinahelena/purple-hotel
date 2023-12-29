using Application.DTOs.Request.ReservationRequest;
using Domain.AggregatesModel;

namespace Application.Mapper;

public static class ReservationMapper
{
    public static ReservationModel Map(ReservationRequest request)
    {
        var reservationModel = new ReservationModel
        {
            CheckinDate = request.CheckinDate,
            CheckoutDate = request.CheckoutDate,
            Code = request.Code,
            GuestsNumber = request.GuestsNumber,
            Status = (int)request.Status,

        };

        if (request.Payment != null)
        {
            reservationModel.Payment = new PaymentModel
            {
                PaymentMethod = (int)(request.Payment.PaymentMethod),
                TotalAmount = request.Payment.TotalAmount,
                Status = (int)request.Payment.Status
            };
        }

        //logica para atualizar room associando reservationId
        //if (request.Room != null)
        //{
        //    reservationModel.Room = new RoomModel
        //    {
        //        Id = request.Room.Id
        //    };
        //    //reservationModel.Room.Id = request.Room.Id;
        //    //reservationModel.Room.HotelId = request.Room.HotelId;
        //    //reservationModel.Room.Number = request.Room.Number;
        //}

        return reservationModel;
    }

}

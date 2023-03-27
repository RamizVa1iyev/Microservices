using Reservation.API.Infrastructure;
using Reservation.API.Models;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetReservationByBookingNumber(int bookingNumber)
        {
            return new ReservationDTO
            {
                Id = (new Random()).Next(100),
                BookingNumber = bookingNumber,
                Amount = (new Random()).Next(10000),
                BookingDate = DateTime.Now,
                CheckInDate= DateTime.Now.AddDays(30),
                CheckOutDate = DateTime.Now.AddDays(37),
            };
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure;
using Reservation.API.Models;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        public ReservationController(IReservationService reservationService)
        {
            this._reservationService = reservationService;
        }

        [HttpGet("{id}")]
        public ReservationDTO Get(int id)
        {
            return this._reservationService.GetReservationByBookingNumber(id);
        }
    }
}

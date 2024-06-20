using BusinessObject;
using DataAccess.DAO;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static DataAccess.DAO.BookingReservationDAO;

namespace DataAccess.Repository
{
    public class BookingReservationRepository : IBookingReservationRepository
    {

        public IEnumerable<BookingReservationWithCustomerName> GetBookingReservationByCustomerId(int customerId) => BookingReservationDAO.GetInstance().GetBookingReservationByCustomerId(customerId);

        public IEnumerable<BookingReservationDTO> GetBookingReservations() =>BookingReservationDAO.GetInstance().GetBookingReservations();
        public IEnumerable<BookingReservationDTO> GetBookingReservations(DateTime startDate, DateTime endDate) =>BookingReservationDAO.GetInstance().GetBookingReservations(startDate, endDate);
        public BookingReservation GetBookingReservationById(int id)
        {
            using (var context = new FUMiniHotelManagementContext())
            {
                return context.BookingReservations
                    .Include(r => r.Customer)
                    .Include(r => r.BookingDetails)
                    .ThenInclude(d => d.Room)
                    .FirstOrDefault(r => r.BookingReservationId == id);
            }
        }

    }
}

using System.Windows;
using BusinessObject;
using DataAccess.Repository;

namespace FUMiniHotelSystem.Admin;

public partial class BookingReservationDetailWindow : Window
{
    public IEnumerable<BookingDetail> BookingDetails { get; set; }

    public BookingReservationDetailWindow(int bookingReservationId)
    {
        InitializeComponent();
        LoadBookingReservationDetails(bookingReservationId);
        DataContext = this;
    }

    private void LoadBookingReservationDetails(int bookingReservationId)
    {
        var bookingReservationRepository = new BookingReservationRepository();
        var bookingReservation = bookingReservationRepository.GetBookingReservationById(bookingReservationId);

        if (bookingReservation != null)
        {
            BookingDetails = bookingReservation.BookingDetails;
        }
        else
        {
            MessageBox.Show("Booking reservation not found.");
            Close();
        }
    }
}
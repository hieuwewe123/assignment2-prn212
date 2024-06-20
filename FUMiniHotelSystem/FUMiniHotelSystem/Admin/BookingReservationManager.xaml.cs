using System.Windows.Controls;
using DataAccess.Repository;

namespace FUMiniHotelSystem.Admin
{
    public partial class BookingReservationManager : Page
    {
        private readonly BookingReservationRepository bookingReservationRepository;

        public BookingReservationManager()
        {
            InitializeComponent();
            bookingReservationRepository = new BookingReservationRepository();
            LoadBookingReservation();
        }

        private void LoadBookingReservation()
        {
            var br = bookingReservationRepository.GetBookingReservations();
            lvBr.ItemsSource = br;
        }

        private void ViewDetail_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Button button = sender as Button;
            int bookingReservationId = (int)button.Tag;

            ShowBookingReservationDetail(bookingReservationId);
        }

        private void ShowBookingReservationDetail(int bookingReservationId)
        {
            var detailWindow = new BookingReservationDetailWindow(bookingReservationId);
            detailWindow.ShowDialog();
        }
    }
}
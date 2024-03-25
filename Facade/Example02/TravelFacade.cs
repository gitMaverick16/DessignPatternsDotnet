namespace Facade.Example02
{
    public class TravelFacade
    {
        private CarRental _carRental;
        private FlightBooking _flightBooking;
        private HotelBooking _hotelBooking;
        public TravelFacade()
        {
            _carRental = new CarRental();
            _flightBooking = new FlightBooking();
            _hotelBooking = new HotelBooking();
        }
        public void ArrangeTrip()
        {
            Console.WriteLine("Start of arrange trip");
            _flightBooking.BookFlight("Lima");
            _hotelBooking.BookHotel();
            _carRental.RentCar();
        }
    }
}

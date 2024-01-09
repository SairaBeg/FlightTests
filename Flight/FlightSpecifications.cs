using Domain;
using Xunit;
using FluentAssertions;

namespace FlightTest

{
    public class FlightSpecifications
    {
        [Fact]
        public void BookingReducesSeats()
        {
            var flight = new Flight( 3);
            
            flight.Book("email", 1);

           flight.RemainingNumberOfSeats.Should().Be(2);
        }

        [Fact]
        public void AvoidOverbooking()
        {
            var flight = new Flight(3);

            var error = flight.Book("email", 4);
            error.Should().BeOfType<OverbookingError>();
        }
    }
}
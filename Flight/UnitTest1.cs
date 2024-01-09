using Domain.Tests;
using Xunit;
using FluentAssertions;

namespace FlightTest

{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var flight = new Flight( 3);
            
            flight.Book("email", 1);

           flight.RemainingNumberOfSeats.Should().Be(2);
        }
    }
}
namespace Domain.Tests
  
{
    public class Flight
    {
        public int seatCapacity {  get; set; }
        public int passengers { get; set; }
        public int RemainingNumberOfSeats { get; set; }
        public Flight(int seatCapacity)
        {
            seatCapacity = this.seatCapacity;
        }

        public void Book(string v1,int newPassengers)
        {
            throw new NotImplementedException();
            //if (passengers == seatCapacity)
            //{
            //    Console.WriteLine("The flight is completely booked");

            //} else if (newPassengers+passengers > seatCapacity)
            //{
            //    Console.WriteLine("Booking that many passengers would overbook the flight.");
            //}
            //else
            //{
            //    Console.WriteLine("Booking your flight...");
            //    passengers += newPassengers;
            //    Console.WriteLine($"Your flight is now booked. There are {passengers} passengers out of {seatCapacity} booked");
            //}
        }

    }
}

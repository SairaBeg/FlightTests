namespace Domain

{
    public class Flight
    {

        public int passengers { get; set; }
        public int RemainingNumberOfSeats { get; set; }
        public Flight(int seatCapacity)
        {

            RemainingNumberOfSeats = seatCapacity;
        }

        public object? Book(string passengerEmail, int newPassengers)
        {

            if (RemainingNumberOfSeats == 0)
            {
                Console.WriteLine("The flight is completely booked");
                return new OverbookingError();

            }
            else if (newPassengers > RemainingNumberOfSeats)
            {
                Console.WriteLine("Booking that many passengers would overbook the flight.");
                return new OverbookingError();
            }
            else
            {
                Console.WriteLine("Booking your flight...");
                passengers += newPassengers;
                RemainingNumberOfSeats -= newPassengers;
                Console.WriteLine($"Your flight is now booked. There are {passengers} booked and  {RemainingNumberOfSeats} seats left");
                return null;
            }
        }

    }
}

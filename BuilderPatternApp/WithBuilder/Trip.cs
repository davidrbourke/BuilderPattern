using System;
using System.Collections.Generic;
using BuilderPatternApp.Core;

namespace BuilderPatternApp.WithBuilder
{
    public class Trip
    {
        public IList<ActivityType> Activities { get; }
        public RestaurantType Lunch { get; set; }
        public RestaurantType Dinner { get; set; }
        public AccommodationType? Accommodation { get; set; }
        public TransportType Transport { get; set; }
        public ClientType Client { get; set; }
        public string TripName { get; set; }

        public Trip()
        {
            Activities = new List<ActivityType>();
        }

        public void Display()
        {
            Console.WriteLine($"\n*** Day Trip - {TripName} ***");
            Console.WriteLine($"Morning: {Activities[0].ToString()}");
            Console.WriteLine($"Lunch: {Lunch.ToString()}");
            Console.WriteLine($"Afternoon: {Activities[1].ToString()}");
            Console.WriteLine($"Dinner: {Dinner.ToString()}");
            if (Accommodation != null)
            {
                Console.WriteLine($"Hotel: {Accommodation.ToString()}");
            }
            Console.WriteLine($"Evening: {Activities[2].ToString()}");
            Console.WriteLine($"Transport: {Transport.ToString()}");
            Console.WriteLine($"Client: {Client.ToString()}");
        }
    }
}

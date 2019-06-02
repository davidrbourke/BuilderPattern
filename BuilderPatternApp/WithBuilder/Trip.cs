using System;
using System.Collections.Generic;
using BuilderPatternApp.Core;

namespace BuilderPatternApp.WithBuilder
{
    public class Trip
    {
        public IList<ActivityType> Activities { get; }
        public RestaurantType Lunch;
        public RestaurantType Dinner;
        public AccommodationType? Accommodation;
        public TransportType Transport;
        public ClientType Client;
        public string TripName;

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

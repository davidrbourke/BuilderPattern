using System;
using System.Collections.Generic;
using System.Text;
using BuilderPatternApp.Core;

namespace BuilderPatternApp.Before
{
    public class DayTrip
    {
        private readonly IList<ActivityType> _activities;
        private readonly RestaurantType _lunch;
        private readonly RestaurantType _dinner;
        private readonly AccommodationType? _accommodation;
        private readonly TransportType _transport;
        private readonly ClientType _client;

        public DayTrip(
            ActivityType morningActivity,
            RestaurantType lunch,
            ActivityType afternoonActivity,
            RestaurantType dinner,
            ActivityType eveningActivity,
            AccommodationType? accommodation,
            TransportType transport,
            ClientType client)
        {
            _activities = new List<ActivityType>
            {
                morningActivity,
                afternoonActivity,
                eveningActivity
            };
            _lunch = lunch;
            _dinner = dinner;
            _transport = transport;
            _client = client;

            if (_client == ClientType.InternationalVisitor && accommodation == null)
            {
                throw new ArgumentNullException(nameof(accommodation), "International visitor must have accommodation");
            }

            _accommodation = accommodation;
        }

        public void Display()
        {
            Console.WriteLine("*** Day Trip ***");
            Console.WriteLine($"Morning: {_activities[0].ToString()}" );
            Console.WriteLine($"Lunch: {_lunch.ToString()}");
            Console.WriteLine($"Afternoon: {_activities[1].ToString()}");
            Console.WriteLine($"Dinner: {_dinner.ToString()}");
            if (_accommodation != null)
            {
                Console.WriteLine($"Hotel: {_accommodation.ToString()}");
            }
            Console.WriteLine($"Evening: {_activities[2].ToString()}");
            Console.WriteLine($"Transport: {_transport.ToString()}");
            Console.WriteLine($"Client: {_client.ToString()}");
        }
    }
}

using BuilderPatternApp.Core;

namespace BuilderPatternApp.WithBuilder
{
    public class SportDayLocalTripBuilder : TripBuilder
    {
        public override void AddMorningActivity()
        {
            Trip.Activities.Add(ActivityType.WembleyFootballMuseumTour);
        }

        public override void AddLunch()
        {
            Trip.Lunch = RestaurantType.GreasySpoonCafe;
        }

        public override void AddAfternoonActivity()
        {
            Trip.Activities.Add(ActivityType.RugbyMatch);
        }

        public override void AddDinner()
        {
            Trip.Dinner = RestaurantType.HardRockCafe;
        }

        public override void AddEveningActivity()
        {
            Trip.Activities.Add(ActivityType.BarsTour);
        }

        public override void AddAccommodation()
        {
            Trip.Accommodation = AccommodationType.None;
        }

        public override void AddTransport()
        {
            Trip.Transport = TransportType.Taxi;
        }

        public override void SetTripName()
        {
            Trip.TripName = "Sport Day";
        }
    }
}

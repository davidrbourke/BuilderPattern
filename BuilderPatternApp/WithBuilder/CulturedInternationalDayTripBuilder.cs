using BuilderPatternApp.Core;

namespace BuilderPatternApp.WithBuilder
{
    public class CulturedDayTripBuilder : TripBuilder
    {
        public override void AddMorningActivity()
        {
            Trip.Activities.Add(ActivityType.TateModern);
        }

        public override void AddLunch()
        {
            Trip.Lunch = RestaurantType.HardRockCafe;
        }

        public override void AddAfternoonActivity()
        {
            Trip.Activities.Add(ActivityType.BritishMuseum);
        }

        public override void AddDinner()
        {
            Trip.Dinner = RestaurantType.HideOfMayfair_MichelinStar;
        }

        public override void AddEveningActivity()
        {
            Trip.Activities.Add(ActivityType.TheLionKingShow);
        }

        public override void AddAccommodation()
        {
            Trip.Accommodation = AccommodationType.TheSavoy;
        }

        public override void AddTransport()
        {
            Trip.Transport = TransportType.Limousines;
        }

        public override void SetTripName()
        {
            Trip.TripName = "Cultured Day";
        }
    }
}

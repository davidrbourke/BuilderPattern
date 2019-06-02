using BuilderPatternApp.Before;
using BuilderPatternApp.Core;
using BuilderPatternApp.WithBuilder;

namespace BuilderPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var dayTrip = new DayTrip(ActivityType.TateModern,
                RestaurantType.HardRockCafe,
                ActivityType.BritishMuseum,
                RestaurantType.HideOfMayfair_MichelinStar,
                ActivityType.TheLionKingShow,
                AccommodationType.TheSavoy,
                TransportType.Limousines,
                ClientType.InternationalVisitor
            );

            dayTrip.Display();

            //var tripDirector = new TripDirector(new CulturedDayTripBuilder());
            //tripDirector.BuildTrip();
            //var culturedTrip = tripDirector.GetTrip();

            //culturedTrip.Display();

            //var sportsTripDirector = new TripDirector(new SportDayLocalTripBuilder());
            //sportsTripDirector.BuildTrip();
            //var sportsTrip = sportsTripDirector.GetTrip();

            //sportsTrip.Display();
        }
    }
}

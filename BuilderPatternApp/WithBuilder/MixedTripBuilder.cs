using System;
using System.Collections.Generic;
using System.Text;
using BuilderPatternApp.Core;

namespace BuilderPatternApp.WithBuilder
{
    public class MixedTripBuilder : TripBuilder
    {
        public override void AddMorningActivity()
        {
            Trip.Activities.Add(ActivityType.ThamesCruise);
        }

        public override void AddLunch()
        {
            Trip.Lunch = RestaurantType.GreasySpoonCafe;
        }

        public override void AddAfternoonActivity()
        {
            Trip.Activities.Add(ActivityType.TheLionKingShow);
        }

        public override void AddDinner()
        {
            Trip.Dinner = RestaurantType.HardRockCafe;
        }

        public override void AddEveningActivity()
        {
            Trip.Activities.Add(ActivityType.WembleyFootballMuseumTour);
        }

        public override void AddAccommodation()
        {
            Trip.Accommodation = AccommodationType.None;
        }

        public override void AddTransport()
        {
            Trip.Transport = TransportType.Walking;
        }

        public override void SetTripName()
        {
            Trip.TripName = "Mixed Trip";
        }
    }
}

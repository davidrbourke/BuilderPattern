using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternApp.WithBuilder
{
    public class TripDirector
    {
        private readonly TripBuilder _tripBuilder;

        public TripDirector(TripBuilder tripBuilder)
        {
            _tripBuilder = tripBuilder;
        }

        public void BuildTrip()
        {
            _tripBuilder.CreateTrip();
            _tripBuilder.SetTripName();
            _tripBuilder.AddMorningActivity();
            _tripBuilder.AddLunch();
            _tripBuilder.AddAfternoonActivity();
            _tripBuilder.AddDinner();
            _tripBuilder.AddEveningActivity();
            _tripBuilder.AddAccommodation();
            _tripBuilder.AddTransport();
        }

        public Trip GetTrip()
        {
            return _tripBuilder.GetTrip();
        }
    }
}

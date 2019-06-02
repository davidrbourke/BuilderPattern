namespace BuilderPatternApp.WithBuilder
{
    public abstract class TripBuilder
    {
        protected Trip Trip;

        public Trip GetTrip()
        {
            return Trip;
        }

        public void CreateTrip()
        {
            Trip = new Trip();
        }

        public abstract void AddMorningActivity();
        public abstract void AddLunch();
        public abstract void AddAfternoonActivity();
        public abstract void AddDinner();
        public abstract void AddEveningActivity();
        public abstract void AddAccommodation();
        public abstract void AddTransport();
        public abstract void SetTripName();
    }
}

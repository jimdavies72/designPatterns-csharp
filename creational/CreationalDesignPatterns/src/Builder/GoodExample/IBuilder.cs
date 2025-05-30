using CreationalDesignPatterns.src.Builder.GoodExample.Components;

namespace CreationalDesignPatterns.src.Builder.GoodExample
{
    public interface IBuilder
    {
        void Reset();
        IBuilder SetCarType(CarType type);
        IBuilder SetSeats(int seats);
        IBuilder IsConvertible(bool isConvertible);
        IBuilder SetEngine(Engine engine);
        IBuilder SetWheels(Wheels wheels);
        IBuilder SetDashboard(Dashboard dashboard);
        IBuilder SetGPSNavigator(GPSNavigator gpsNavigator);
    }
}
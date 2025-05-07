using CreationalDesignPatterns.src.Builder.GoodExample.Components;

namespace CreationalDesignPatterns.src.Builder.GoodExample;

public class RunBuilderGoodExample
{
  public static void RunBuilderPatternGoodExample()
  {
    // method 1 - build the car steps in the client
    // var carBuilder = new CarBuilder();
    // carBuilder.SetCarType(CarType.Sports)
    //     .SetSeats(2).SetEngine(new Engine())
    //     .SetDashboard(new Dashboard(hasRevCounter: true))
    //     .SetWheels(new Wheels(diameterInInches: 20));

    // var sportsCar = carBuilder.GetCar();
    // sportsCar.Fuel = 100;

    // var manualBuilder = new CarManualBuilder();
    // manualBuilder.SetCarType(CarType.Sports)
    //     .SetSeats(2).SetEngine(new Engine())
    //     .SetDashboard(new Dashboard(hasRevCounter: true))
    //     .SetWheels(new Wheels(diameterInInches: 20));

    // var sportsCarManual = manualBuilder.GetManual();
    // Console.WriteLine(sportsCarManual.Print());

    // method 2 - build the car steps in a Director
    var carBuilder = new CarBuilder();
    var director = new Director();

    director.ConstructSportsCar(carBuilder);
    var sportsCar = carBuilder.GetCar();
    sportsCar.Fuel = 100;

    director.ConstructSUV(carBuilder);
    var suvCar = carBuilder.GetCar();
    suvCar.Fuel = 40;

    var manualBuilder = new CarManualBuilder();

    director.ConstructSportsCar(manualBuilder);
    var sportsCarManual = manualBuilder.GetManual();
    Console.WriteLine(sportsCarManual.Print());

    director.ConstructSUV(manualBuilder);
    var suvCarManual = manualBuilder.GetManual();
    Console.WriteLine(suvCarManual.Print());
  }
}

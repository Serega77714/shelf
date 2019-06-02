using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            PassengerRide SeatCar1 = new PassengerRide(1, 11);
            SeatCar1._TrainViev = "passenger";
            Console.WriteLine($"TrainViev - {SeatCar1._TrainViev},Comfort Level={SeatCar1._Comfort}  WagType - {SeatCar1.WagType}");
            Console.WriteLine($"number of passengers= {SeatCar1._NumOfPas}, amount of baggage={SeatCar1._AmOfBag() }kg");
            Console.WriteLine();

            PassengerRide CommonCar1 = new PassengerRide(2, 58);
            CommonCar1._TrainViev = "passenger";
            Console.WriteLine($"TrainViev - {CommonCar1._TrainViev},Comfort Level={CommonCar1._Comfort}  WagType - {CommonCar1.WagType}");
            Console.WriteLine($"number of passengers= {CommonCar1._NumOfPas}, amount of baggage={CommonCar1._AmOfBag() }kg");
            Console.WriteLine();

            PassengerRide EconClassCar1 = new PassengerRide(3, 25);
            EconClassCar1._TrainViev = "passenger";
            Console.WriteLine($"TrainViev - {EconClassCar1._TrainViev},Comfort Level={EconClassCar1._Comfort}  WagType - {EconClassCar1.WagType}");
            Console.WriteLine($"number of passengers= {EconClassCar1._NumOfPas}, amount of baggage={EconClassCar1._AmOfBag() }kg");

            PassengerRide CoupeCar1 = new PassengerRide(4, 37);
            CoupeCar1._TrainViev = "passenger";
            Console.WriteLine($"TrainViev - {CoupeCar1._TrainViev},Comfort Level={CoupeCar1._Comfort}  WagType - {CoupeCar1.WagType}");
            Console.WriteLine($"number of passengers= {CoupeCar1._NumOfPas}, amount of baggage={CoupeCar1._AmOfBag() }kg");
            Console.WriteLine();

            PassengerRide LuxCar1 = new PassengerRide(5, 58);
            LuxCar1._TrainViev = "passenger";
            Console.WriteLine($"TrainViev - {LuxCar1._TrainViev},Comfort Level={LuxCar1._Comfort}  WagType - {LuxCar1.WagType}");
            Console.WriteLine($"number of passengers= {LuxCar1._NumOfPas}, amount of baggage={LuxCar1._AmOfBag() }kg");
            Console.WriteLine();



        }
    }
}

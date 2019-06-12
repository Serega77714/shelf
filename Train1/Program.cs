using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Train1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Youcreated train types:");
            Console.WriteLine();           

            CommonCar _CommonCar = new CommonCar(trainCarNumber: 1, wagType: "CommonCar ", comfort: 2, numOfPas: 56, amOfBag: 630);

            _CommonCar.TrainCarGetInfo();

            LuxCar _LuxCar = new LuxCar(trainCarNumber: 2, wagType: "LuxCar ", comfort: 5, numOfPas: 13, amOfBag: 700);

            _LuxCar.TrainCarGetInfo();

            EconClassCar _EconClassCar = new EconClassCar(trainCarNumber: 3, wagType: "EconClassCar ", comfort: 3, numOfPas: 15, amOfBag: 354);

            _EconClassCar.TrainCarGetInfo();

            CoupeCar _CoupeCar = new CoupeCar(trainCarNumber: 4, wagType: "CoupeCar ", comfort: 4, numOfPas: 10, amOfBag: 333);

            _CoupeCar.TrainCarGetInfo();

            SeatCar _SeatCar = new SeatCar(trainCarNumber: 5, wagType: "SeatCar ", comfort: 1, numOfPas: 32, amOfBag: 520);

            _SeatCar.TrainCarGetInfo();

            
            List<TrainCar> Train = new List<TrainCar>();
            Train.Add(_SeatCar);
            Train.Add(_EconClassCar);
            Train.Add(_LuxCar);
            Train.Add(_CoupeCar);
            Train.Add(_CommonCar);

           


            var SNumOfPas = Train.Sum(i => i.NumOfPas);
            var SamOfBag = Train.Sum(i => i.AmOfBag);
            var OrdByComfort = Train.OrderBy(i => i.Comfort).ToList();
            var TrCarNumOfPas = OrdByComfort.FindAll(i => i.NumOfPas < 20);


            Console.WriteLine("The sorted by comfort train:");

            foreach (var TrCar in OrdByComfort)
            {
                Console.WriteLine($"Train Car Number: {TrCar.TrainCarNumber},Wag Type: { TrCar.WagType},Comfort:{ TrCar.Comfort}, NumOfPas : {TrCar.NumOfPas}, amOfBag:{TrCar.AmOfBag}kg"); 
            }
            Console.WriteLine();
            Console.WriteLine($"The sum of all passengers on the train:{ SNumOfPas}");
            Console.WriteLine($"The sum of all baggage on the train:{ SamOfBag}");
            Console.WriteLine();

            Console.WriteLine("train with less than 20 passengers:");
            foreach (var TrCar in TrCarNumOfPas)
            {
                Console.WriteLine($"Train Car Number: {TrCar.TrainCarNumber},Wag Type: { TrCar.WagType}, NumOfPas : {TrCar.NumOfPas}, amOfBag:{TrCar.AmOfBag}kg"); ;
            }



        }

    }
}

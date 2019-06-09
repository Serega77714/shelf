using System;
using System.Collections.Generic;
using System.Text;

namespace Train1
{
    class CommonCar : TrainCar
    {
        public CommonCar(int trainCarNumber, string wagType, int numOfPas, int amOfBag) : base(trainCarNumber, wagType, numOfPas, amOfBag)
        {
            //int numOfPas = _NumOfPas();
            //int AmOfBag = _NumOfPas() * 50; // генерация колличества багажа: на одного пассажира 50кг
        }

        Random _numOfPas = new Random();

        public int _NumOfPas() // генерация колличества пассажиров
        {
            int n = _numOfPas.Next(1, 62); // в сидячем вагоне 62 посадочных места
            return n;
        }


        public void TrainCarGetInfo()
        {
            Console.WriteLine($"Train Car Number: { TrainCarNumber},Wag Type: { WagType}, NumOfPas : {NumOfPas}, amOfBag:{AmOfBag}");
        }
    }
}

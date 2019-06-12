using System;
using System.Collections.Generic;
using System.Text;

namespace Train1
{
    abstract class TrainCar
    {
        public int TrainCarNumber { get; set; } //номер вагона
        public string WagType { get; set; } //типа вагона (сидячий(SeatCar), общий(CommonCar), плацкартный(EconClassCar), купейный(CoupeCar) , люкс(LuxCar))
        public int Comfort { get; set; }
        public int NumOfPas { get; set; }

        public int AmOfBag { get; set; }

        public TrainCar(int trainCarNumber, string wagType, int comfort, int numOfPas, int amOfBag)
        {
            TrainCarNumber = trainCarNumber;
            WagType = wagType;
            Comfort = comfort;
            NumOfPas = numOfPas;
            AmOfBag = amOfBag;
        }

      

        public abstract void TrainCarGetInfo();
        
        //public virtual int _NumOfPas(int max) // генерация колличества пассажиров
        //{
        //    Random _numOfPas = new Random();
        //    int n = _numOfPas.Next(1, max); // в сидячем вагоне max посадочных места
        //    return n;
        //}

    }
}

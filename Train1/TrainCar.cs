using System;
using System.Collections.Generic;
using System.Text;

namespace Train1
{
    abstract class TrainCar
    {
        public int TrainCarNumber { get; set; } //номер вагона
        public string WagType { get; set; } //типа вагона (сидячий(SeatCar), общий(CommonCar), плацкартный(EconClassCar), купейный(CoupeCar) , люкс(LuxCar))
        public int NumOfPas { get; set; } //количество пассажиров
        public int AmOfBag { get; set; }  //количество багажа
        //private int Comfort { get; set; } //уровень комфортности

        public TrainCar(int trainCarNumber, string wagType, int numOfPas, int amOfBag)
        {
            TrainCarNumber = trainCarNumber;
            WagType = wagType;
            NumOfPas = numOfPas;
            AmOfBag = amOfBag;
            //Comfort = comfort;
        }
        //abstract public TrainCarCreate();
    }
}

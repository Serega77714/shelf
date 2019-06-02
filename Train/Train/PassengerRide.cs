using System;
using System.Collections.Generic;
using System.Text;

namespace Train
{
    public class PassengerRide : TrainCar
    {
        public string WagType; //типа вагона (сидячий(SeatCar), общий(CommonCar), плацкартный(EconClassCar), купейный(CoupeCar) , люкс(LuxCar))
        private int NumOfPas; //количество пассажиров
        private int AmOfBag;  //количество багажа
             

        public int _NumOfPas
        {
            get { return NumOfPas; }
            set { NumOfPas = value; }
        }
        public int _AmOfBag()
        {
            AmOfBag = NumOfPas * 50;
            return AmOfBag;
        }
        private int Comfort;
        public int _Comfort  //уровень комфорта(passenger or freight)
        {
            get { return Comfort; }

            set
            {
                switch (value)
                {
                    case 1:
                        WagType = "SeatCar";
                        break;
                    case 2:
                        WagType = "CommonCar";
                        break;
                    case 3:
                        WagType = "EconClassCar";
                        break;
                    case 4:
                        WagType = "CoupeCar";
                        break;
                    case 5:
                        WagType = "LuxCar";
                        break;
                    default:
                        WagType = "Error.Enter comfort level from 1..5";
                        break;
                }
                Comfort = value;

            }

        }
        public PassengerRide(int Comfort, int _NumOfPas)
        {
            _Comfort = Comfort;
            NumOfPas = _NumOfPas;
            
        }
       


    }
}

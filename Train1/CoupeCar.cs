using System;
using System.Collections.Generic;
using System.Text;

namespace Train1
{
    class CoupeCar : TrainCar
    {
        public CoupeCar(int trainCarNumber, string wagType, int numOfPas, int amOfBag) : base(trainCarNumber, wagType, numOfPas, amOfBag)
        {
        }
        public int comfort = 4;
    }
}


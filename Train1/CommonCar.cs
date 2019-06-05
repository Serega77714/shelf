using System;
using System.Collections.Generic;
using System.Text;

namespace Train1
{
    class CommonCar : TrainCar
    {
        public CommonCar(int trainCarNumber, string wagType, int numOfPas, int amOfBag) : base(trainCarNumber, wagType, numOfPas, amOfBag)
        {
        }
        public int comfort = 2;
    }
}

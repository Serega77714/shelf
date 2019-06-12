using System;
using System.Collections.Generic;
using System.Text;

namespace Train1
{
    class CommonCar : TrainCar
    {
      
        public CommonCar(int trainCarNumber, string wagType, int comfort, int numOfPas, int amOfBag) : base(trainCarNumber, wagType, comfort, numOfPas, amOfBag)
        { }

        public override void TrainCarGetInfo()
        {
            Console.WriteLine($"Train Car Number: { TrainCarNumber},Wag Type: { WagType},Comfort:{Comfort} NumOfPas : {NumOfPas}, amOfBag:{AmOfBag}kg");
        }


    }
}


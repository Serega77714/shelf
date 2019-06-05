using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Train1
{
    class TrainCreate
    {
        public TrainCreate()
        {
            var Train = new List<object>();
            Random rend = new Random();

            for (int i = 0; i < 10; i++)
            {
               int n = rend.Next(1, 5);
                switch (n)
                {
                    case 1:Train.Add("SeatCar");
                        break;
                    case 2:
                        Train.Add("CommonCar");
                        break;
                    case 3:
                        Train.Add("EconClassCar");
                        break;
                    case 4:
                        Train.Add("CoupeCar");
                        break;
                    case 5:
                        Train.Add("LuxCar");
                        break;
                    //case 6:
                    //    Train.Add(new SeatCar() {trainCarNumber=2,wagType="35",numOfPas=6, amOfBag=5 });
                    //    break;
                }
                             
             }
            Console.WriteLine("You created a train of cars:");
            foreach (var item in Train)
            {
                Console.Write($" :: {item}");
                                
            }
            Console.WriteLine();
            Console.WriteLine(Train[2]);
        }
}    }   
    
    //Train1[1]=

    //{Train.Add(rend.Next(1, 5));}
    //public int n = rend.Next(1, 5); 


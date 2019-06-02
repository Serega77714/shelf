using System;
using System.Collections.Generic;
using System.Text;

namespace Train
{
    public class TrainCar
    {
        private string TrainViev;

        public string _TrainViev  //пассажирский или товарный(passenger or freight)
        {
            get { return TrainViev; }

            set
            {
                if (value == "passenger" || value == "freight")
                    TrainViev = value;
                else
                    Console.WriteLine($"You entered '{value}', Enter 'passenger' or 'freight");
            }


        }

        //public int TrainCarNumber;
    }
}
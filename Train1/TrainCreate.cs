using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Train1
{
    public class TrainCreate
    {
        public TrainCreate()
        {
             var Train = new List<object>();
            Random rend = new Random(); //переменная для рандомного создания вагонов
            Random _numOfPas = new Random();
            
            int _NumOfPas() // генерация колличества пассажиров
            {
                int n = _numOfPas.Next(1, 62); // в сидячем вагоне 62 посадочных места
                int bag = n * 50;
                return n;

            }
            int _AmOfBag() // генерация колличества багажа: максимально 50 кг на количество пассажиров
            {
                int n = _NumOfPas() * 50;
                return n;
            }
           



            for (int i = 0; i < 11; i++) //создает поезд из 10 рандомных вагонов
            {
                int n = rend.Next(1, 5);
                switch (n)
                {
                    case 1:
                        Train.Add(new SeatCar(trainCarNumber: i, wagType: "SeatCar", numOfPas: _NumOfPas(), amOfBag: _AmOfBag()));
                        break;
                    case 2:
                        Train.Add(new CommonCar(trainCarNumber: i, wagType: "CommonCar", numOfPas: _NumOfPas(), amOfBag: _AmOfBag()));
                        break;
                    case 3:
                        Train.Add(new EconClassCar(trainCarNumber: i, wagType: "EconClassCar", numOfPas: _NumOfPas(), amOfBag: _AmOfBag()));
                        break;
                    case 4:
                        Train.Add(new CoupeCar(trainCarNumber: i, wagType: "CoupeCar", numOfPas: _NumOfPas(), amOfBag: _AmOfBag()));
                        break;
                    case 5:
                        Train.Add(new LuxCar(trainCarNumber: i, wagType: "LuxCar", numOfPas: _NumOfPas(), amOfBag: _AmOfBag()));
                        break;
                }

            }
            Console.WriteLine("You created a train of cars:");
            Console.WriteLine();
            Console.WriteLine($"Train Car Number:{ (Train[0] as TrainCar).TrainCarNumber +1},Wag Type: {(Train[0] as TrainCar).WagType}");
            Console.WriteLine($"Num Of Pas={(Train[0] as TrainCar).NumOfPas}, amount of baggage {(Train[0] as TrainCar).AmOfBag}kg");

            Console.WriteLine();
            Console.WriteLine($"Train Car Number:{ (Train[1] as TrainCar).TrainCarNumber + 1},Wag Type: {(Train[1] as TrainCar).WagType}");
            Console.WriteLine($"Num Of Pas={(Train[1] as TrainCar).NumOfPas}, amount of baggage {(Train[1] as TrainCar).AmOfBag}kg");

            Console.WriteLine();
            Console.WriteLine($"Train Car Number:{ (Train[2] as TrainCar).TrainCarNumber + 1},Wag Type: {(Train[2] as TrainCar).WagType}");
            Console.WriteLine($"Num Of Pas={(Train[2] as TrainCar).NumOfPas}, amount of baggage {(Train[2] as TrainCar).AmOfBag}kg");

            Console.WriteLine();
            Console.WriteLine($"Train Car Number:{ (Train[3] as TrainCar).TrainCarNumber + 1},Wag Type: {(Train[3] as TrainCar).WagType}");
            Console.WriteLine($"Num Of Pas={(Train[3] as TrainCar).NumOfPas}, amount of baggage {(Train[3] as TrainCar).AmOfBag}kg");

            Console.WriteLine();
            Console.WriteLine($"Train Car Number:{ (Train[4] as TrainCar).TrainCarNumber + 1},Wag Type: {(Train[4] as TrainCar).WagType}");
            Console.WriteLine($"Num Of Pas={(Train[4] as TrainCar).NumOfPas}, amount of baggage {(Train[4] as TrainCar).AmOfBag}kg");

            Console.WriteLine();
            Console.WriteLine($"Train Car Number:{ (Train[5] as TrainCar).TrainCarNumber + 1},Wag Type: {(Train[5] as TrainCar).WagType}");
            Console.WriteLine($"Num Of Pas={(Train[5] as TrainCar).NumOfPas}, amount of baggage {(Train[5] as TrainCar).AmOfBag}kg");

            Console.WriteLine();
            Console.WriteLine($"Train Car Number:{ (Train[6] as TrainCar).TrainCarNumber + 1},Wag Type: {(Train[6] as TrainCar).WagType}");
            Console.WriteLine($"Num Of Pas={(Train[6] as TrainCar).NumOfPas}, amount of baggage {(Train[6] as TrainCar).AmOfBag}kg");

            Console.WriteLine();
            Console.WriteLine($"Train Car Number:{ (Train[7] as TrainCar).TrainCarNumber + 1},Wag Type: {(Train[7] as TrainCar).WagType}");
            Console.WriteLine($"Num Of Pas={(Train[7] as TrainCar).NumOfPas}, amount of baggage {(Train[7] as TrainCar).AmOfBag}kg");

            Console.WriteLine();
            Console.WriteLine($"Train Car Number:{ (Train[8] as TrainCar).TrainCarNumber + 1},Wag Type: {(Train[8] as TrainCar).WagType}");
            Console.WriteLine($"Num Of Pas={(Train[8] as TrainCar).NumOfPas}, amount of baggage {(Train[8] as TrainCar).AmOfBag}kg");

            Console.WriteLine();
            Console.WriteLine($"Train Car Number:{ (Train[9] as TrainCar).TrainCarNumber + 1},Wag Type: {(Train[9] as TrainCar).WagType}");
            Console.WriteLine($"Num Of Pas={(Train[9] as TrainCar).NumOfPas}, amount of baggage {(Train[9] as TrainCar).AmOfBag}kg");


            



            
           
        }
    }    }   
    
   


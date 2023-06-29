using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car- done
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable- done
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()- done
            //The methods should take one string parameter: the respective noise property -done


            //Now that the Car class is created we can instanciate 3 new cars

            //created car 1
            Car myCar = new Car();

            //set the property values using dot notation
            myCar.Make = "Dodge";
            myCar.Model = "Charger";
            myCar.Year = 2022;       
            myCar.IsDriveable= true;
            myCar.EngineNoise = "vroom vroom";
            myCar.HonkNoise = "honkkk!";

            //called methods
            myCar.MakeEngineNoise();
            myCar.MakeHonkNoise();



            //created car 2
            Car myCar2 = new Car();

            //set the property values using dot notation
            myCar2.Make = "Mclaren";
            myCar2.Model = "720s";
            myCar2.Year = 2021;
            myCar2.IsDriveable = true;
            myCar2.EngineNoise = "vromm shpoosh";
            myCar2.HonkNoise = "honkkk honk honkkkk";

            //called methods
            myCar2.MakeEngineNoise();
            myCar2.MakeHonkNoise();




            //created car 3
            Car myCar3 = new Car();

            //set the property values using dot notation
            myCar3.Make = "Jeep";
            myCar3.Model = "Trackhawk";
            myCar3.Year = 2020;
            myCar3.IsDriveable = true;
            myCar3.EngineNoise = "vromm popppp popp";
            myCar3.HonkNoise = "honkkk honkkkk";

            //called methods
            myCar3.MakeEngineNoise();
            myCar3.MakeHonkNoise();







            //Set the properties for each of the cars -done
            //Call each of the methods for each car - done

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}

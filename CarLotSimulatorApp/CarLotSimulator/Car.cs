using System;
namespace CarLotSimulator
{
    public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; }

        public bool IsDriveable { get; set; }



        public void MakeEngineNoise()
        {
            Console.WriteLine($" The engine is running {EngineNoise} .");
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine($"The car is honking {HonkNoise}.");
        }




        public class myCar2
        {
            public string Make { get; set; }

            public string Model { get; set; }

            public int Year { get; set; }

            public string EngineNoise2 { get; set; }

            public string HonkNoise2 { get; set; }

            public bool IsDriveable { get; set; }



            public void MakeEngineNoise()
            {
                Console.WriteLine($"The engine is loud {EngineNoise2}.");
            }

            public void MakeHonkNoise()
            {
                Console.WriteLine($"The car is honking at me {HonkNoise2}.");
            }




            public class myCar3
            {
                public string Make { get; set; }

                public string Model { get; set; }

                public int Year { get; set; }

                public string EngineNoise3 { get; set; }

                public string HonkNoise3 { get; set; }

                public bool IsDriveable { get; set; }



                public void MakeEngineNoise()
                {
                    Console.WriteLine($"The engine is loud {EngineNoise3}.");
                }

                public void MakeHonkNoise()
                {
                    Console.WriteLine($"The car is honking at me {HonkNoise3}.");
                }






            }
        }
    }
}

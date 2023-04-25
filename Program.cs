namespace CarsAndUsedCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("Ford","F-150", 2023, 50000);
            Car c2 = new Car("Dodge", "Grand Caravan", 2020, 28000);
            Car c3 = new Car("Subaru", "Legacy", 2022, 23000);
            UsedCar c4 = new UsedCar("Acura", "CL", 1997, 3000, 289000);
            UsedCar c5 = new UsedCar("Ford", "Taurus", 1998, 5000, 80000);
            UsedCar c6 = new UsedCar("Subaru", "Forrester", 2014, 13000, 99000);
            List<Car> Cars = new List<Car>() { c1, c2, c3, c4, c5, c6};
            Console.WriteLine("Welcome to the Car Depot!");
            Console.WriteLine();

            for (int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine((i+1) + " " + Cars[i].ToString());
            }
            bool goOn = true;
            while (goOn)
            {
                Console.WriteLine("Which car would you like?");
                int input = -1;
                bool tryInput = false;
                while (tryInput == false) 
                {
                    try
                    {
                        input = int.Parse(Console.ReadLine());
                        tryInput = true;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Please enter a valid number.");
                        continue; 
                    }
                    
                }
                Console.WriteLine();
                Console.WriteLine("Congrats on your purchace of the:");
                Console.WriteLine(Cars[input - 1]);
                Console.WriteLine();
                Cars.RemoveAt(input - 1);

                Console.WriteLine("Would you like to keep shopping? y/n");
                string input2 = Console.ReadLine();
                if(input2 == "y")
                {
                    for (int i = 0; i < Cars.Count; i++)
                    {
                        Console.WriteLine((i + 1) + " " + Cars[i].ToString());
                    }
                    continue;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Have a Nice Day!");
                    break;
                }

                
            }



        }
    }
}
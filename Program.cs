using ParkingApplication.Models;

Parking parking = new Parking();


Console.WriteLine("-------------------------");
Console.WriteLine("");
Console.WriteLine("Please type the initial price: ");
string initialPriceString = Console.ReadLine();
decimal.TryParse(initialPriceString, out decimal initialPrice);
Console.WriteLine("");
Console.WriteLine("-------------------------");


Console.WriteLine("");
Console.WriteLine("-------------------------");
Console.WriteLine("");
Console.WriteLine("Please, type the price per hour: ");
string pricePerHourString = Console.ReadLine();
decimal.TryParse(pricePerHourString, out decimal pricePerHour);
Console.WriteLine("");
Console.WriteLine("-------------------------");


List<string> vehicleList = new List<string>();
string option = string.Empty;



while (option != "4")
{
    Console.WriteLine("");
    Console.WriteLine("-------------------------");
    Console.WriteLine("");
    Console.WriteLine("Please, type your option:");
    Console.WriteLine("1 - Register a vehicle");
    Console.WriteLine("2 - Remove a vehicle");
    Console.WriteLine("3 - List vehicles");
    Console.WriteLine("4 - End program");
    option = Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("-------------------------");


    switch (option)
    {
        case "1":
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");
            Console.WriteLine("Type the vehicle license plate: ");
            string licensePlate = Console.ReadLine();
            vehicleList.Add(licensePlate);
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
        break;

        case "2":
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");
            Console.WriteLine("Type the vehicle license plate to remove: ");
            licensePlate = Console.ReadLine();
            vehicleList.Remove(licensePlate);
            Console.WriteLine("Type how many hours the vehicle has been parked: ");
            string parkedTimeString = Console.ReadLine();
            decimal.TryParse(parkedTimeString, out decimal parkedTime);
            decimal totalToPay = parking.TotalToPay(initialPrice, pricePerHour, parkedTime); 
            Console.WriteLine($"The vehicle {licensePlate} has been removed and the total price was {totalToPay.ToString("C2")}");
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
        break;

        case "3":
            if (vehicleList.Count == 0)
            {
                Console.WriteLine("No vehicles parked.");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("-------------------------");
                Console.WriteLine("");
                Console.WriteLine("Parked vehicles:");
                foreach (string vehicle in vehicleList)
                {
                    Console.WriteLine(vehicle);
                }
                Console.WriteLine("");
                Console.WriteLine("-------------------------");
             }
        break;

        case "4":
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");
            Console.WriteLine("Program ended. Thank you!");
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
        break;
    
        default:
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");
            Console.WriteLine("Please, type a valid option");
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
        break;
    }
}
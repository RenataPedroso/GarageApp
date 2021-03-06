using System.Globalization;
using GarageApp.Entities;
<<<<<<< HEAD
using GarageApp.Services;
=======
>>>>>>> 1f7fa443c812ee805cbdefa39976d71e5ef8a0d2

namespace GarageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new(hour, day);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
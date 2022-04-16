using System;
using System.Globalization;
using TrainingEleven.Entities;
using TrainingEleven.Entities.Exception;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine(reservation);

                Console.WriteLine();
                Console.Write("Updates for reservation? (y/n)");
                char answer = char.Parse(Console.ReadLine());

                if (answer == 'y')
                {
                    Console.Write("Check-in date (dd/MM/yyyy): ");
                    checkin = DateTime.Parse(Console.ReadLine());
                    Console.Write("Check-out date (dd/MM/yyyy): ");
                    checkout = DateTime.Parse(Console.ReadLine());

                    reservation.UpdateDates(checkin, checkout);
                    Console.WriteLine(reservation);
                }
                else
                {
                    Console.WriteLine("Thank you for your visit!");
                }
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Model = "Toyota";
            car.Make = "Corolla";
            car.Year = 2016;

            Console.WriteLine($"This car is a {car.Model} {car.Make}, made in the year {car.Year}");
        }
    }
}

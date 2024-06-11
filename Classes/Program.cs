namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!")

        Car car1 = new Car();
            car1.year = 1;
            car1.Make = "aventador";
            car1.Model = "lamborghini";
        }
    }
}
public class Car
{
    public Car() 
    {
    }
public string Make { get; set; }
    public string Model { get; set; }
    public int year { get; set; }
}
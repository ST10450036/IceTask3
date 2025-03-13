namespace IceTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of the Circle and Rectangle classes
            Rectangle myRecObj = new Rectangle(5, 10);
            myRecObj.Display();
            myRecObj.CalculateArea();

            Circle myCircObj = new Circle(5);
            myCircObj.Display();
            myCircObj.CalculateArea();

            Console.ReadKey();
        }
    }
}

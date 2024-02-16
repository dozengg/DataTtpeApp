namespace DataTtpeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the pieces of apple: ");
            int apple = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter total price of " +apple+ " apple(s): ");
            double price = Convert.ToDouble(Console.ReadLine());

            int converprice = (int) price;

            Console.WriteLine("The total price of " + apple + " apple(s)" + price);
            Console.WriteLine("The value of original price is " + price);

            Console.WriteLine("The value fo converted price is " + converprice);
        }
    }
}   
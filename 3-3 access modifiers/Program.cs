using Amazon;

namespace _3_3_access_modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            //var rating = customer.CalculaterRating();
            
            var customer1 = new Customer1();
            //Amazon.RateCalculator calculator = new RateCalculator();
        }
    }
}

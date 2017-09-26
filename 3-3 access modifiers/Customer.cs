using System;

namespace _3_3_access_modifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            /*var rating = CalculaterRating(excludeOrder: true);
            if (rating == 0)
            {
                Console.WriteLine("Promoted to Level 1");
            }
            else
            {
                Console.WriteLine("Promoted to Level 2");
            }*/

            Console.WriteLine("Promote logic changed.");
        }

        /*protected int CalculaterRating(bool excludeOrder)
        {
            return 0;
        }*/
    }
}
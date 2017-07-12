using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
        // Create an empty HashSet named `Showroom` that will contain strings.
           HashSet<string> Showroom = new HashSet<string>();

        // Add four of your favorite car model names to the set.
           Showroom.Add("Honda");
           Showroom.Add("Audi");
           Showroom.Add("Lexus");
           Showroom.Add("Nissan");

        // Print to the console how many cars are in your show room.
           Console.WriteLine(Showroom.Count);

           foreach( string car in Showroom){
            //Console.WriteLine(car);
           }

        // Pick one of the items in your show room and add it to the set again.
            Showroom.Add("Nissan");


        // Print your showroom again, and notice how there's still only one representation of that model in there.
            foreach( string car in Showroom){
                Console.WriteLine("Showroom cars: " + car);
            }

        // Create another set named `UsedLot` and add two more car model strings to it.
            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("BMW");
            UsedLot.Add("Fiat");

            foreach(string usedCar in UsedLot) {
                Console.WriteLine("UsedLot cars: " + usedCar);
            }

        // Use the `UnionWith()` method on `Showroom` to add in the two models you added to `UsedLot`.
            Showroom.UnionWith(UsedLot);
            
            foreach (string newLot in Showroom) {
                Console.WriteLine("UnionWith: " + newLot);
            }

        // You've sold one of your cars. Remove it from the set with the `Remove()` method.
            Showroom.Remove("Fiat");

            foreach (string remainingStock in Showroom) {
                Console.WriteLine("Remaining cars: " + remainingStock);
            }


        //  Now create another HashSet of cars in a variable Junkyard.
            HashSet<string> Junkyard = new HashSet<string>();

        //  In the new set, add some different cars, but also add a few that are the same as in the Showroom set.
            Junkyard.Add("Honda");
            Junkyard.Add("Nissan");
            Junkyard.Add("Ford");
            Junkyard.Add("Hyundai");
            Junkyard.Add("Saturn");
            Junkyard.Add("GMC");

        //  Use the IntersectWith() method to see which cars exist in both the show room and the junkyard.
            Showroom.IntersectWith(Junkyard);

            foreach (string multiples in Showroom) {
                Console.WriteLine("These are repeats: " + multiples);
            }

        //  Use the UnionWith() method to combine the junkyard into your showroom.
            Showroom.UnionWith(Junkyard);

            foreach (string readyToSell in Showroom){
                Console.WriteLine("Ready to sell: " + readyToSell);
            }

        //  Use the Remove() method to remove any cars that you acquired from the junkyard that you want in your showroom.
            Showroom.Remove("Hyundai");

            foreach (string finalShowRoom in Showroom) {
                Console.WriteLine("Final list of cars: " + finalShowRoom);
            }
        }
    }
}

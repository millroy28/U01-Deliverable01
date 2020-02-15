using System;

namespace U01_Deliverable01
{
    class Program
    {
        static void Main(string[] args)
        {

            string vacationType;    //user input 
            string vacationDest;    //determined destination
            int groupSize;          //user input
            string travelMethod;    //determined travel method
            
            Console.WriteLine("What type of trip would you like to go on, musical, tropical, or adventurous?");
            vacationType = Console.ReadLine();
            Console.WriteLine("How many are in your group?");
            groupSize = int.Parse(Console.ReadLine());

            if (vacationType == "musical")
            {
                vacationDest = "New Orleans";
            } else if (vacationType == "tropical")
            {
                vacationDest = "a beach vacation in Mexico";
            } else
            {
                vacationDest = "a whitewater rafting expedition in the Grand Canyon";
            }

            if (groupSize >= 1 && groupSize <= 2)
            {
                travelMethod = "first class flight";
            } else if (groupSize >= 3 && groupSize <= 5)
            {
                travelMethod = "helicopter";
            } else
            {
                travelMethod = "charter flight";
            }

            string result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + travelMethod + " to " + vacationDest + ".";
            Console.WriteLine(result); 
            
        }
    }
}

using System;

namespace Casting_Dallas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a whole number here pls");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"the number you pick was {userNumber}");
        
            Console.WriteLine("Do you like video games? True or False.");
            bool likeGames = Convert.ToBoolean(Console.ReadLine());
            if (likeGames)
            {
                Console.WriteLine("So you do like games good!");
            }             
            else    
            {
                Console.WriteLine("WoW cant beleve you dont like games what are you doing here!");
            }                  
               
             

        }
    }
}

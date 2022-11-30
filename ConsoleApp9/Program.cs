using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp9
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var getrod = new
            {
                FuelCapacity = 30,
                FuelFor1Km = 2,
                CurrentFuel=20,

            }; 
            int gett = getrod.CurrentFuel / getrod.FuelFor1Km;//burada cureent yanacaqla ne qeeder yol gede bleceyin hesablayiriq
           
            
            Console.WriteLine(Drive(17,gett));
        }
        static int Drive(int road,int gett)
        {
            var getrod = new
            {
                FuelCapacity = 30,
                FuelFor1Km = 2,
                CurrentFuel = 20,

            };
            int finalfuel = getrod.CurrentFuel - getrod.FuelFor1Km * road;

            if ( gett > road)
            {
                return finalfuel;
            }
            return 0;//yanacaq yoxdursa 0 gosterir
        }
        
    }
}
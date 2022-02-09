using System;
using System.Collections.Generic;


namespace ClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();

            car.Make = "Dodge";

            car.Model = "Challenger";

            car.Year = 2013;
            
             Console.WriteLine($"{car.Make} {car.Model} {car.Year}") ;




        }

    }       
            
}


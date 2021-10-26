/// Chapter No. 11 - Homework9_Project1
/// File Name: Homework9_week9_Project1.java
/// @author: Rossana Palma
/// Date:  October 18, 2021
///
/// Problem Statement:  Define a class called Odometer that will be used to track 
/// fuel usage and miles per gallon.    
/// 
/// Overall Plan:
/// 1) Create an Odometer class
/// 2) Create two constructors, 1 constructor should be the no-argument constructor 
/// the other will set the two instance variables.
/// 3) Include a reset method that sets the mileage drive and the fuel used to zero
/// 4) Include an add method which takes two parameters that add to the fuel consumed 
/// and the miles driven.
/// 5) create a method that returns the miles per gallon 
/// and an appropriate ToString method
/// 6) Write a driver program that tests all the methods and constructors.  


using System;

namespace Homework_week9_Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Odometer trip1 = new Odometer(); // 1st Odometer : class name  2nd Odometer : constructor
            trip1.add(50, 10);
            Console.WriteLine("Fuel used for trip 1 is: " + trip1.MPG());
            Odometer trip2 = new Odometer();
            trip2.add(100, 20);
            Console.WriteLine("Fuel used for trip 2 is: " + trip2.MPG());
            trip1.reset();
            Console.WriteLine("Fuel used for trip 1 is: " + trip1.toString());

            trip2.add(150, 0);
            Console.WriteLine("Fuel used for trip 2 is: " + trip2.MPG());


            Console.ReadLine();
                                      
        }
        public static int Addition(int n1, int n2)
        {
            return n1 + n2;
        }

    }
}

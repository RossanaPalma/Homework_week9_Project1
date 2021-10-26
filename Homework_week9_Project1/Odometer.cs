using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_week9_Project1
{
    class Odometer
    {
        private int miles;
        private double fuelUsed;
        //Constructors
        public Odometer()
        {

        }
        public Odometer(int miles, double fuelUsed)
        {
            this.miles = miles;
            this.fuelUsed = fuelUsed;
        }
        //Quick actions
        public int Miles { get => miles; set => miles = value; }

        public double FuelUssed { get => fuelUsed; set => fuelUsed = value; }

        //Methods
        public void reset()
        {
            miles = 0;
            fuelUsed = 0;
        }
        public void add(int m, double f)
        {
            miles += m; // miles = miles + m;
            fuelUsed += f; // fuelUsed = fuelUsed + f;
        }
        public double MPG()
        {
            return (miles / fuelUsed);
        }
        public String toString()
        { 
            return " " + miles + " miles driven " + fuelUsed + " fuel used";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFall18
{
    public class Vehicle
    {
        //Fields
        string make; //Vehicle make
        string model; //Vehicle model
        string year; //Vehicle year
        double engSize; //Vehicle engine size
        int rimSize; //Vehicle rim size
        string color; //Vehicle color
        
        //Properties
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public string Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        public double EngSize
        {
            get { return this.engSize; }
            set { this.engSize = value; }
        }
        public int RimSize
        {
            get { return this.rimSize; }
            set { this.rimSize = value; }
        }
        public string Color
        {
            get { return this.Color; }
            set { this.Color = value; }
        }

        //Constructors
        public Vehicle()
        {

        }
        public Vehicle(string veh_make)
        {
            this.Make = veh_make;
        }
        public Vehicle(string veh_make, string veh_model)
        {
            this.Model = veh_model;
        }
        public Vehicle(string veh_make, string veh_model, string veh_year)
        {
            this.Year = veh_year;
        }

        //Methods
        public int GetMph()
        {
            return (0);
        }
    }
}

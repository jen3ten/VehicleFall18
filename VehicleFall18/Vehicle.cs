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
    }
}

﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFall18.Tests
{
    //Vehicle OOP Assignment
    //Build a base vehicle class using the tests given in the requirements
    //  -vehicles have model, make, year, engine size, rum size, and color properties
    //  -the Vehicle class should have a default constructor and additional constructors
    //  -additional constructors should set make; make and model; make, model, and year
    //  -the class has a method to GetMph using distance and time
    //  -the class has a second method to GetMpg using end odometer, start odometer, and tank size

    [TestFixture]
    class VehicleTests
    {
        [Test]
        public void Create_Veh_CTR_0_Input()
        {
            ////Test the instantiation of the default Vehicle class
            ////The vehicle class should have a make property that is null

            //Arrange
            Vehicle vehicle = new Vehicle();
            //Act
            string response = vehicle.Make;
            //Assert
            Assert.That(response, Is.EqualTo(null));
        }

        [Test]
        public void Create_Veh_CTR_1_Input()
        {
            ////Test the instantiation of the Vehicle class with one value parameter
            ////The vehicle class should have a make property that sets the value "Ford"

            //Arrange
            Vehicle vehicle = new Vehicle("Ford");
            //Act
            string response = vehicle.Make;
            //Assert
            Assert.That(response, Is.EqualTo("Ford"));
        }

        [Test]
        public void Create_Veh_CTR_2_Input()
        {
            ////Test the instantiation of the Vehicle class with 2 value parameters
            ////The vehicle class should take in "Ford" and "Bronco"
            ////The vehicle class should have a model property that sets the value "Bronco"

            //Arrange
            Vehicle vehicle = new Vehicle("Ford", "Bronco");
            //Act
            string response = vehicle.Model;
            //Assert
            Assert.That(response, Is.EqualTo("Bronco"));
        }

        [Test]
        public void Create_Veh_CTR_3_Input()
        {
            ////Test the instantiation of the Vehicle class with 3 value parameters
            ////The vehicle class should take in "Ford", "Bronco", and "1965"
            ////The vehicle class should have a year property that sets the value "1965"

            //Arrange
            Vehicle vehicle = new Vehicle("Ford", "Bronco", "1965");
            //Act
            string response = vehicle.Year;
            //Assert
            Assert.That(response, Is.EqualTo("1965"));
        }
    }
}

using NUnit.Framework;
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

        [Test]
        public void Set_Engine_Size()
        {
            ////Test the Engine size property
            ////Set engine size to 5.0 and return 5.0

            //Arrange
            Vehicle vehicle = new Vehicle();
            //Act
            vehicle.EngSize = 5.0;
            //Assert
            Assert.That(vehicle.EngSize, Is.EqualTo(5.0));
        }

        [Test]
        public void Set_Rim_Size()
        {
            ////Test the Rim size property
            ////Set rim size to 16 and return 16

            //Arrange
            Vehicle vehicle = new Vehicle();
            //Act
            vehicle.RimSize = 16;
            //Assert
            Assert.That(vehicle.RimSize, Is.EqualTo(16));
        }

        [Test]
        public void Set_Veh_Color()
        {
            ////Test the vehicle color property
            ////Set vehicle color to red and return red

            //Arrange
            Vehicle vehicle = new Vehicle();
            //Act
            vehicle.Color = "red";
            //Assert
            Assert.That(vehicle.Color, Is.EqualTo("red"));
        }

        [Test]
        public void Get_MPH_Return_0()
        {
            ////Test that GetMph() method returns 0

            //Arrange
            Vehicle vehicle = new Vehicle();
            //Act
            int response = vehicle.GetMph(0, 0);
            //Assert
            Assert.That(response, Is.EqualTo(0));
        }

        [Test]
        public void Get_MPH_Return_9()
        {
            ////Test that GetMph() method returns 9 if time=7, distance=1

            //Arrange
            Vehicle vehicle = new Vehicle();
            //Act
            int response = vehicle.GetMph(1.0, 7.0);
            //Assert
            Assert.That(response, Is.EqualTo(9));
        }

        [Test]
        public void Get_MPG_Return_49_94()
        {
            ////Test that GetMpg() method returns 49.94 if
            ////  startODO = 3579
            ////  endODO = 3117 ?? end is smaller than start??
            ////  tankSize = 9251 ?? what is the unit here??

            //Arrange
            Vehicle vehicle = new Vehicle();
            //Act
            string response = vehicle.GetMpg(3579.0, 3117.0, 9.251);
            //Assert
            Assert.That(response, Is.EqualTo("49.94"));
        }
    }
}

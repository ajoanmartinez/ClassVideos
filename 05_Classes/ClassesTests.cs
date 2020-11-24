using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void CookieTests()
        {

            // calling my cookie class (type), then call new instance/variable (new up), or a new reference type
            Cookie cookie = new Cookie(); // This is a cookie object
            cookie.Name = "Snickerdoodle";  // making a new object called cooke, which sets the name property of the above cookie
            cookie.HasNuts = false;
            
            Cookie anotherCookie = new Cookie(); // this is a new cookie object
            anotherCookie.Name = "Something else";
            anotherCookie.GramsOfFlour = 10;

            // This allows us to have many related variables in one object
            // We can set these properties for each object by itself

            Cookie snickerdoodle = new Cookie("Snickerdoodle", false, 11.5);  // I am giving it arguments for its parameters, these will then be set to the classes properties
            // The benefit here^^ is that this new object is initialized wiht all of its properties are set
            // We have taken our three lines of code in ClassExamples where we have set those properties, and put them somewhere where they are reusable

            // So new up a new cookie below

            Cookie newCookie = new Cookie("Peanut Butter", true, 150);
            // ^^setting all our properties based on these parameters, from the one constructer we have built we can use it as many times as we need anywhere else
            // Makes our implementation much cleaner

            // What do we do when we want to initialize an object without having to make a bunch of different overloading contructors? <SEE VEHICLE CLASS>
        }
        [TestMethod]
        public void VehicleTests()
        {
            Vehicle car = new Vehicle();// when we new up an object, we call these two parenthesis (), we always put these parenthesis for parameters
            car.TypeOfVehicle = VehicleType.Car;

            // How ti initialize an object with out creting overloaiding constructors

            Vehicle newCar = new Vehicle  // New up without () and instead use {}
            {
                TypeOfVehicle = VehicleType.Car,  // Object initialization syntax = opening a new Vehicle, and then setting properites here, not all, but the ones we want to set
                Make = "Honda",
                Model = "Civic"
               
            };

        }

    }
}

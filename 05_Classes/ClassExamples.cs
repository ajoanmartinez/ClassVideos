using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes // Namespace does not have to be the name of our classes

    // We can have as many classes as we want, Examples = class Dog, class Cat, class Dragon
{
    public class Cookie    // Just like methods, classes can have access modifiers, by default in C# our classes are going to be internal, same as our methods
    {
        // Think about what defines this object, how do we describe a cookie? to do that  givit it properties, it's a variable that defines the class, and most of the time it's public

        public string Name { get; set; } // Anything that is not a local variable or a parameter is going t be pascal cased
        public bool HasNuts { get; set; }
        public double GramsOfFlour { get; set; }

        // We are going to go ahead with adding a constructor to our code
        // Remember this is a method that is accessable from the outside, so declare the access modifier as public
        // Constructors have a couple of rules: 1) They don't have a return type. 2.) They always have to have the same name of the class




        // Overloading Methods

        // Create a constructor that has the same name as, even though typically we can only make unique name methods
        public Cookie() // Methods signature must be unique, "Cookie()" is the method signature
        {
            // We still need the overloaded black constructer so that we can make empty object if we need it, wihtout it we cannot make an empty object and set its properties when I get them, or need them

        }

        public Cookie(string name, bool hasNuts, double gramsOfFlour)  // This is our Cookie.Cookie method, this is going to be our constructor, when we new up a Cookie, the below code will fire off
            // because the constructor is a meethod, I can pass in paramerter within the ()
            // in the above constructor we have created parameters with the same name that our properties have, because we are going to take our properties and set them equal to the parameters in the constructor
            // so when you call the constructor we are going to give a string bool, and a double
        {
            Name = name;
            HasNuts = hasNuts;
            GramsOfFlour = gramsOfFlour;

            // So when we new up a cookie we can give it it's Name, Hasnuts, GramsOfFlour right away
            // However if you we go over to ClassesTests, and look at our method, there is an error, because we wrote over the implicit constructor with an explicit constructor
            // and that method is still calling a constructor that takes in zero parameters
            // to keep the methods working in ClassesTests, we need to add another constructor, we do this by overloading methods (SEE ABOVE)
 
        }

    }

    public enum VehicleType
    {
        Car, Truck, Van, Motorcycle, Spacecship, Plane, Boat // With an enum we get to create a brand new type and give it all of its values (see property below)
    }

    public class Vehicle
    {
        // What defines a vehicle? Make and Model... so, make a property for make and model, and add a few more properties after make and model for fun

        public string Make { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; } // If I want to set options we can make a type of vehicle object using enum (see above)

        public Vehicle()  // This is our constructor for Vehicle.Vehicle, so when we new up a Vehicle, it will fire off the below chunck of code
        {

        }

    }

    // Now use a class object as a property type
    public class Order // Include who the customer is an what they bought and the total of their order, so that order is not affected by what is changed to the cookie class (or changes to the cookie)
    {
        public string CustomerName { get; set; }
        public Cookie OrderedProduct { get; set; }
        public decimal TotalCost { get; set; }
    }

    // Next we will work on constructors
    // constructors are a special type of method, a chunk of code you want to fire off when you construct an object
    // In C# if you don't define a constructor, then there will be an empty complicit instructor in the background, there has to be a chunck of code somewhere if we don't define our own 


    
  

}


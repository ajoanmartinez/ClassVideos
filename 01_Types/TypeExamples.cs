using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            //--Value types are some type that has one value -- Examples are numbers
            //--Variables have 3 different parts 
            //--First delcare what type it is
            //--Second name the variable type, naming format starts with a lower case letter, and every other word after that will start with a capital letter
            //--Third initialize the variable by assigning a value to it




            //--Whole Numbers

            //--Below is a declaration of a variable "byte" type called (name) "oneBytesWorth"
            byte oneBytesWorth;
            //--If I want to give oneByetesWorth a value then... 
            oneBytesWorth = 255;    //--A byte has a minimum value of 0 and a maximum value of 255

            //--Below is a declaration of a variable type "short" called (name) "smallWholenumber "and initialized with a value of 16
            //--I.e., I have delcared variable named smallWholenumber is a short type assigned with a value of 16
            short smallWholeNumber = 16;         //-- this is Int16, see below line for another way of declaring this variable type
            Int16 anotherSmallNumber = 16;    

            //--Below is a declaration of a variable type "int" called (name) "wholenumber" and initialized with a value of 32
            int wholeNumber = 32;
            Int32 anotherWholenumber;

            //--Below is a declaration of a variable type "long" called (name) "largeWholeNumber and initialized with a value of 64
            long largeWholeNumber = 64;
            Int64 anotherLargeWholeNumber;

            //--The different types of signed integers are only whole numbers. 
            //--The bits have all to do with memory and how much space one of these variables takes up
            //--Example if I wanted to a very big number I may need to use a long 
            //--int type is the most common, but if we get into projects that require memomry management, then we will see more usage of short, long and byte types





            //--Decimals
            //--3 main types

            float floatExample = 1.234567f;
            //--Use f at the end to indicate it is a float

            double doubleExample = 1.237979;
            //--No suffix, because decimals in C# are implicitly doubles, but I can specifcy this is a double by adding a "d" at the end of the assigned value (e.g. 1.237979d)

            decimal decimalExample = 1.70000m;
            //--Need to add the suffix "m" at the end of the assigned value





            //-- Character (Another Value Type)

            char letter = 'j';
            //--In C# assign value to character type by using single quotes '', which tells us this is a single character. If you replace 'j' with 'jo', then you will get an error 
            //--You can enter special characters for char type, like '\n', because the code sees the \ as a return (it has to compile down to a single character)
            
            
            
            
            
            //--C# is very stronly typed, Example, when creating the "oneBytesWorth" and declare the type is a byte, for the entire existance of "oneBytesWorth" it is going to be a byte
            //--I can take oneBytesWorth and set it equal to something else
            int newNumber = oneBytesWorth;
            //--This means I can take that value of oneBytesWorth and assign that value to a new integer, but oneBytesWorth itself is always going to be a byte






            //--Operators

            //--Including these inside our Valuetypes because we have our numbers declared here

            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);

            int diff = numOne - numTwo;
            Console.WriteLine(diff);

            int prod = numOne * numTwo;
            Console.WriteLine(prod);

            int quot = numOne / numTwo;         //--17 / 5 = 3, because we are workng with integers, we will always get a whole number, not a decimal in these examples
            Console.WriteLine(quot);

            int remainder = numOne % numTwo;    //--17 % 5 = 2, because we are workng with integers, we will always get a whole number, not a decimal in these examples
            Console.WriteLine(remainder);
            //--This is called modulus which takes numOne divides it by numTwo and gives the value of the remainder

            Console.WriteLine("Hello"); //--wrties to the console


        }

        //--New Test Method
        [TestMethod]  //--Need this annotation for the test explorer to see RefereceTypes public void
        public void ReferenceTypes()
        {
            //--To declare as many and any characters as you want use strings and ""



            //--Strings
            string stringExample = "This is string.";
            //Declare               //Initialize

            string name = "Amy";

            string declared;
            //Declared but not initialized

            declared = "Now it's initialized.";
            //Declared and initialized





            //--Formatting strings
            string concatenate = stringExample + " " + name;  //--Takes both strings and slams them together = "This is a string. Amy" 

            //--Need " " or the word space to create the space betwee strngExample and name


            string interpolate = $"{name}. Here is the string: {stringExample}"; //--Amy. Here is the string: This is a string.
            //--Plug in a variable, so that you code it that "name" can change to whatever it is    
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);





            //--Other Object Examples
            //--Objects are core to C#. Structs, interfaces, classes are all sorts of different types that make objects. This is a brief introdocution

            DateTime now = DateTime.Now; //--The DateTime.Now is the actual time this line of code executes, not when the application starts
            //type  //name  //class name // property -- creating an instance called now
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2020, 11, 13); //--Year, Month, Day
            //type   //name     //new up  //Constructor

            TimeSpan waitTime = randomDate - now;       //--DateTime specifically allows us to take one DateTime and subtract another DateTime from it, and that gives us a time span, or time interval
            Console.WriteLine(waitTime.TotalSeconds);
            //. is the down operator  //TotlSeconds is property





            //--Collections     //--Also a reference type, a category of types

            //--Arrays 
            
            //-- Not often used in C#, C# uses other things
            string anotherExampleString = "Hello World";
            //Indicate an array by using []
            //Whenw we declare a collection, we also have to specify what that collection holds
            string[] stringArray = { anotherExampleString, "Hello", "World", "!" }; //--This string array holds all four of these values
            //String arrays have a predetermined size, so when I make an array, I have to give it its size
            string[] students = new string[15];
            //newing up a new array called students and it is assigned 15 spots for its value, so for students I can never have 16 or 14 items, I may have a blank value, but I still have that slot

            Console.WriteLine(stringArray); //--Taking this stringArray object and turning it into the the equivalent of a string. 
            //It doesn't know how to output the four values, it just knows it is a system.string array




            //--Lists
            List<string> listOfStrings = new List<string>(); //--Does not have a predetermined size, so I can just keep adding 
            listOfStrings.Add("Lawrence");


            //--Queues
            Queue<string> firstInFirstOut = new Queue<string>(); //--First in First out, first person in line, is the first person out of the line
            firstInFirstOut.Enqueue("Luke");


            //--Dictionaries
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();     //--Key value pairs. You have to give it a key and a value
            keyValuePair.Add('j', "Amy"); //--You need the key j to get in the door, and when you get in you get "Amy"


            //-Other Collection
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>(); //--Example, loading dishes in to a dishwasher, the first that goes in are the last that come out





        }

    }
}

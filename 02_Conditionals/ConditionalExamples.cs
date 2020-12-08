using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class ConditionalExamples
    {        

        //Conditionals are a chunk of code that evaluates some condition
        //Life example, if a person his hungry, then the person should eat
        //In code we evaluate condtiions, then have the code execute something based on that condtion
        //This is done by evaluating boolean statements

        [TestMethod]
        public void Booleans()
        {
                
            
            //Boolean is a true/false statement
            //In C# can show booleans as a type

            bool isTrue = 17 > 5;
            bool isFalse = 17 == 4;
            //bool type    //bool statement

        }


        // now we can take this plug into condtional code

        [TestMethod]
        public void IfElseStatements()
        {
            bool isTrue = true;
            if (true)
            {
                //Do Something here 
            }

            int age = 12;

            if (age > 17)
            {
                Console.WriteLine("You're an adult.");
            }
            else if (age > 6)  //--Nesting/Stacking
            {
                Console.WriteLine("You're a kid");
            }
            else if (age > 0) //--Nesting/Stacking
            {
                Console.WriteLine("You're far too young to be on a computer.");
            }
            else  //--One catch all else every other condition not evaluated 
            {
                Console.WriteLine("You're not even born yet");
            }


            if (age > 65 && age < 18)
            {
                // AND comparison &&
            }

            if (age <= 65 || age >= 18)
            {
                // Ore comparison ||
            }

            if (age == 17)
            {
                // Is equal to
            }

            if (age != 19)
            {
                //not equal to
                // ! bang operator
            }

            // We can stack all of these conditions



        }

        [TestMethod]
        public void SwitchCases()
        {

            //--About checking specific conditions in each case
            //--In the case the sky is blue do something
            //--In the case you are 18 do something

            int age = 42;

            
            switch (age) //--Use switch keword then what we are evaluating (age)
            {
                case 18: //--the case of 18
                    // code if age is 18
                    break;  //--breaks us out of the switch case once we evlaute one that is true
                case 19:
                    //code for if age is 19
                    break;
                case 20:
                    // code for if age is 20
                    break;
                case 21:
                case 22:
                case 23:
                    // code here for 21-23 -- this is stacking -- these cases will execute the same code
                    break;                
                default:
                    // catch all code -- // cannot do "case all:" but can do default
                    Console.WriteLine("You are not 18-23"); //--It will fire this line of code
                    break;

                    //--only good for indvidual cases, cannot do range
            }

        }
        [TestMethod]
        public void Ternaries()
        {
            int age = 37;

            // bariable = (boleean statement) ? trueValue : falseValue
            //                                      // if true do this // if false do this

            bool isAge = (age == 24) ? true : false;

        }

        

        
       
        
      

    }

}

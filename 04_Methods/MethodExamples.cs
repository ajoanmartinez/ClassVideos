using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class MethodExamples
    {
        //--Method = A resuable chunck of code 
        //Input
        //What we do
        //Output 

        //Methods are made up of 4 parts, see below:

        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        private int SubtractTwoNumbers(int a, int b)
        {
            int num = a - b;
            return num;
        }

        private int MultiplyTwoNumbers(int x, int z)
        {
            int prod = x * z;
            return prod;
        }

        private int DivideTwoNumbers(int apricot, int cherry)
        {
            int fruitSalad = apricot / cherry;
            return fruitSalad;
        }

        private int FindRemainder(int a, int numTwo)
        {
            int remainder = a % numTwo;
            return remainder;
        }

        [TestMethod]
        public void MethodTests()
        //1     //2    //3a    //3b     

            //1 - Access modifier -- Modifies how accessible this method is
            //2 - Return type -- This is the output, what type we are going to output (void means we are going to do something but not output anything)
            //3a - Method signature - Name of method (Method signature is made up of two parts, this is part 1)
            //3b - Method signature - Parameters (Method signature is made up of two parts, this is part 2)

            

        {
            //4 - The body of the method, the part of the code that does something

            int banana = AddTwoNumbers(7, 12);
            int sumTwo = AddTwoNumbers(5, 42);

            // Tests only fail if given a reason to fail
            // Another way to make a test fail, is to assert something is going to happen and then tha thing does  not happen

            Assert.AreEqual(19, banana); //Asserting that 19 and banana are equal, if we change the 19 to 1, then we are validating that code is correct, but the out come was not what I expected

            int subtractedBanana = SubtractTwoNumbers(10, 5);
            Assert.AreEqual(5, subtractedBanana);

            int product = MultiplyTwoNumbers(12, 5);
            Assert.AreEqual(60, product);

            int fruitSalad = DivideTwoNumbers(10, 4);
            Assert.AreEqual(2, fruitSalad);

            int remainder = FindRemainder(10, 4);
            Assert.AreEqual(2, remainder);

            // Methods are good for logic only when we something to be done
            // Another way of making a chunck of resuable code is by making a class
        }
    }// This is a large class object, that holds different methods
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void ForLoops()
        {
            //For Loop is made up of 4 main parts
            //1 Starting Point fires off only once
            //2 Condition that while true, keeps the loop running
            //3 Whawt happens after each loop
            //4 Bod of the loop, what happens each iteration


            int studentCount = 15;
            
            //for   //1    //2              //3
            for (int i = 0; i < studentCount; i++) // i = i + i; -> i++
            {
                //4
                Console.WriteLine(i); 
            }
        }
        [TestMethod]
        public void ForeeachLoops()
        {
            //Similar to a for loop
            //Instead of having to give it a predetermined custom endpoint and wha to happen each time, a foreach loop is good at working with collections
            //It will do the same chunck of code for each thing in that colletion

            string name = "Eleven Fifty Academy"; //--Collection of characters ... E, L, E.. etc... so we can run code through each character of this string

            //Parts of a foreach loop
            //1 Collection that's being worked on
            //2 Name of the curret iteration being used
            //3 Current type in teh collection
            //4 in keyword, used to separate the invidual and the colelction
            //5 body of the loop

            
            //foreach //3      //2   //4 //1
            foreach (char letter in name)
            {
                Console.WriteLine(letter); //5 Will execute code for each letter in the string
            }
        }
        [TestMethod]
        public void WhileLoopos()
        {
            //Simple, they are a loop that runs while a condition is true

            int total = 1;


            //Parts of whileloop
            //1 Loop runs while the condition is true
            //2 the body of the loop

            //while    //1
            while (total != 30)
            {
                Console.WriteLine(total);
                total++; /// total = total + 1; ... Can also do --, but this loop would run forever because the total would never be 30 if int total = 1
            }
        }

    }
}

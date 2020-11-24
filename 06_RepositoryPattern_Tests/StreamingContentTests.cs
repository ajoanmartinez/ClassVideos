using System;
using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_RepositoryPattern_Tests
{
    // The question we need to answer before writing tests, "What are we trying to test?"
    // For now we are writing tests for our POCO


    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            // Start by defining what this test is going to look like, what are the steps we need to take
            // If we want to test some streaming content, then we want to set the title
            // We can't set a title yet because we don't have an instance of our streamig content object 
            // So we need to create an instance of our POCO
            // To create an instance of our POCO we need to set references to our namespaces, becuause unit test is in 06_RepositoryPattern_Tests and our POCO is in 06_RepositoryPattern_Repository
            // Once we add the reference ""_Repository to ""_Tests, it now allows ""_Tests to see everything that is public in the namespace ""_Repository

            StreamingContent content = new StreamingContent(); // This line creating a blank slate

            // Now set title
            content.Title = "Toy Story"; // This line we are creating a "Toy Story" name

            // Now declare variables
            string expected = "Toy Story"; // This line gathering data
            string actual = content.Title; // THis line gathering data

            Assert.AreEqual(expected, actual); // The argument names do not need to match the parameter names, only doint it here for clarity; This line checking to make sure they are equal to each other

     
        }
    }
}

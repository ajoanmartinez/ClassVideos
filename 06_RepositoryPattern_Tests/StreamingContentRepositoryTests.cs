using System;
using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        // FROM BOTTOM SCROLL UP TO HERE

        // ----- TEST INITIALIZE METHOD ----- // 

        // For the test initialize, we need to declare a couple of fields for this example

        private StreamingContentRepository _repo;
        private StreamingContent _content;

        
        [TestInitialize]  
        public void Arrange()  // Test Initialize says that this method must run at the beginning of every single test, Arrange does NOT have to the be name, it does have to be public, and.. 
            // ...void to not return anything
        {
            // In this method we can assign a value to the delacared fields _repo and _content
            _repo = new StreamingContentRepository(); // Here we have our streaming content reposiroty field that is accessable to all methods
            _content = new StreamingContent("Rubber", "A car tire comes to life with the power to make people explode and goes on a murderous rampage thorugh the Californian desert.", "R", 5.8, false,
                GenreType.Drama);  // Here we have our new instance streaming content that has some values assigned to it also available to all methods because it's a field 

            _repo.AddContentToList(_content); // Here we have added the content to the list so that when we access this repo field we can see everything that is on that repo in every single method

            // ----- NO GO BACK TO UPDATE METHOD ----- //

        }

        
        
        // ---- NOTES START HERE ----/// 



        // ----- ADD METHOD ----- //

        // The goal is to test our add functionality
        // A couple of different approaches
        // Lookig at ""_Repository, when adding content to list, we don't get feedback, no return type
        // We can mix a couple of different couple of methods
        // For our purpose we need to add content to list, but also need to verify content has been added
        // So we can either use our GetContentList, or we can use our GetContentByTitle
        // For this example, we will use GetContentByTitle to verify it's been added to the list, and verify that the object that is returned is not null
        
        [TestMethod]
        public void AddToList_ShouldGetNotNull()// Add Method
        {
            // ----- AAA PARADIGM ----- //

            // Arrange
            // Act
            // Assert



            // ----- ARRANGE ----- // --> SETTING UP THE PLAYING FIELD

            // Start by getting out our content and our repository
            StreamingContent content = new StreamingContent(); // Streaming content object            
            content.Title = "Toy Story"; // Give our content a name, or title            
            StreamingContentRepository repository = new StreamingContentRepository(); // Streaming content repository

           
            
            // ----- ACT ----- // --> GET/RUN THE CODE WE WANT TO TEST
            
            // Now add our content to the repository list
            repository.AddContentToList(content);

            // Now that we've added our content to the repository through our method, now we want to get the content back and verify that it's not a null object
            StreamingContent contentFromDirecotry = repository.GetContentByTitle("Toy Story"); //Getting the content back,and passing "Toy Story" again

            

            // ----- ASSERT ----- // --> USE THE ASSERT CLASS TO VERIFY THE EXPECTED OUTCOME
            
            // Now that we have our object, we can assert that the object that has been given is not null 
            Assert.IsNotNull(contentFromDirecotry);

        }

        // ----- UPDATE METHOD ----- //

        // Note: Every time we run a unit test we have to do everything from the top down
        // 1) We have to create streaming content object
        // 2) We have to create the repository
        // 3) We have to add the object to the repository
        // 4) We have to then update the object
        // 5) We have to then verify the update worked
        // 6) We then have to assert 

        // For all of our tests we can set up some other methods and other content to make it where we don't have to do every single step every single time 
        // NOW SCROLL TO TOP OF UNIT TEST FOR NEXT STEPS

        [TestMethod]
        public void UdpateExistingContent_ShouldReturnTrue()
        {
            // Arrange
            // TestIntitilaize
            // We also want to add new content, whatever our udpated content is going to be 

            StreamingContent newContent = new StreamingContent("Rubber 2", "A car tire comes to life with the power to make people explode and goes on a murderous rampage thorugh the Californian desert.", "R", 5.8, 
                false, GenreType.RomCom);

            // Act
            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);


            // Assert
            Assert.IsTrue(updateResult);

        }

        // ----- DATA TEST METHOD ---- //

        [DataTestMethod]
        [DataRow("Rubber", true)]
        [DataRow("Toy Story", false)]
        public void UpdateExistingContent_ShouldmatchGivenBool(string originalTitle, bool shouldUpdate)  // We will see this done with attributes in data test rows, but change title into a parameter here
        {
            // Arrange
            // TestIntitilaize
            // Copy/Paste from test methid UpdateExistingContent_ShouldReturnTrue()

            StreamingContent newContent = new StreamingContent("Rubber 2", "A car tire comes to life with the power to make people explode and goes on a murderous rampage thorugh the Californian desert.", "R", 5.8,
                false, GenreType.RomCom);

            // Act
            bool updateResult = _repo.UpdateExistingContent(originalTitle, newContent);


            // Assert
            Assert.AreEqual(shouldUpdate, updateResult);
        }

        [TestMethod]
        public void DeleteConetnet_ShouldReturnTrue()
        {
            // Arrange
            // Test Initialize

            // Act
            bool deleteResult = _repo.RemoveConetentFromList(_content.Title);

            // Assert
            Assert.IsTrue(deleteResult);
        }

    }
}

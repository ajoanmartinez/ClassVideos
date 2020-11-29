using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
   
    
    // The goal of this class is to hold all of our CRUD


    public class StreamingContentRepository
    {
        // ----- CRUD ----- //


        // Create -- Enables us to to create streaming content

        // Read -- Enables us to to read streaming content

        // Update -- Enables us to to update streaming content

        // Delete -- Enables us to to delete streaming content

        // These^^ are operations
        // Q: What does this CRUD pertain to? 
        // A: We need the ability to do the above operations, AND 
        // A: That means that we need someplace to store all of that streaming content once it's created,
        // A: Or pull it from somewhere once it's been created and it's stored, and we just want to read it, 
        // A: Or we need to find it, and update it
        // This class is going to be the manipulater of that data, as well as, the holder of that data



        // ----- FIELD ----- //


        // So... the first thing we want to do here is create a field at the top of our class        
        // Before we make a field, let's review properities
        // Properites are class level variables, but they more define the class as, "here's what this class looks like"
        // A field, is also a class level variable

        private List<StreamingContent> _listOfContent = new List<StreamingContent>();

        // When creating a field we are not creating a variable that defines the class
        // Instead when creating a FIELD we are making a VARIABLE IN THE CLASS that can be USED EVERYWHERE 
        // Scope - Anytihng that's made in a class, or anything that can see it's siblings can be used
        // IMPORTANT NOTE ON SCOPE -- SEE StreamingConentRepositoryClass 
        // We apply the same concept of starting outward and working inward to our field
        // I.e., we are going to make a field, which is a variable, that can be used in every single one of our CRUD methods
        // I.e, each mehtod will be able to use the same list, _listOfContent, that way we have a persisting object that holds of all our different StreamingContent objects

        
        
        // ----- CRUD METHODS ----- //
        
        // So now, let's create our CRUD methods
        // We need to make sure that all of these methods are accessable outside, 
        // i.e., when we new up a streaming content repository we want to be able to call our CRUD methods, so let's make them publc



        // ----- CREATE ----- //

        public void AddContentToList(StreamingContent content) // First Method, It's adding content to list, taking in streaming content object called content, it's not returning anything
        {
            _listOfContent.Add(content); // to add content to the list, we are calling the field from inside the method, then calling the .Add method, 
            //and because we are calling the .Add method we have to take in content from outsdie to add to list. We don't know where the content is coming from, just that we have to take "content" in,
            // and then add it to the list, _listOfContent
            
            //NOTE: We are putting the underscore here in front of listOfContent, and saying that anything that has an underscore at the beginning of its name is going to be a field
        }

        // Note when it pertains to our return type, we want our methods to follow the SINGLE RESPONSIBILITY PRINCIPLE
        // So if we are just adding, we don't need it to return anything, so we will use void as our reutrn type



       
        
        // ----- READ ----- //
        
        // To read from the list, what we need to do is first remember that the list is encapsulated away, it cannot be accessed outside
        // So we need to build a bridge to get to the list, so we do this by building a new public method
        // The return type here needs to return the list of streaming content
        // Since the single responsiblity of this method is to get the content list, We don't need be told which list, because we only have one list we can get, so we don't need parameters

        public List<StreamingContent> GetContentList()
        {
            return _listOfContent;
            // Here, when we are calling GetContentList method, this allows us to access the list _listofContent, but ONLY when we are calling GetContentList method

        }




        
        //------ UPDATE------//

        // We need to be able to be given our new preferred "what we want our content to look like," but we also need to know what it looked like before

        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent) // Need to know what was original content and what is our new content, so we pass string of orignalTitle, 
                                                                                             //...and new streaming content object called newContent
        {
            // First find the content
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            // Then update the content
            // Remember it's upossible that we could be passed a null object
            if(oldContent != null)
            {

                //Remember, if we have the below list as an example, and we want to update B, then...
                // A
                // B  -- ... we do not want to rip out B, and then replace with E at the bottom of list, instead we want to update B's properties 
                // C
                // D

                // So we will call oldContent which is our object we found in that list and make = to newContent for all of our properties
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
                oldContent.StarRating = newContent.StarRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;

                return true;

                // Here we are taking the parameter of our new content and setting it as the parameter of our old content
                // Taking the new values taken from the new streaming content object, and assigning them to the existing object on that list 
                // Because these are references, we have a list that is a reference to some address, so we want to do is say, "Old content in spot B in that list, here are your new values."
                // I.e., item B is staying in that same index, we are just updating its values
            }
            else
            {
                return false;
            }

            // Refacting the return type here from void to bool allows us to call this method from somewhere else it's going to give us a true/false, we get a little bit of feedback
        }
        
        



        // -----DELETE ----- //

        public bool RemoveConetentFromList(string title) // The pareters here can be set to either take in a title, and use content by title, or take in the full streaming content object, here we are just passing... 
            // ...title
        {
            // First need to find that content by its title 
            StreamingContent content = GetContentByTitle(title);

            // Now we are taking title from RemoveContentFromList parameter, passing it to GetConentByTitle parameter, where it will then iterate through the HELPER METHOD to find it, and if it is found
            // it will return it here, and if it does not, it will return null here

            if(content == null)
            {
                return false; // We return false because we will not be able to remove the content if it is not found
            }

            // If not null, then we know we found the content, but we need to check to make sure it was successfully removed from list

            int initialCount = _listOfContent.Count; // Count is a property of _listOfContent that will give us the number of elements in the list
            _listOfContent.Remove(content); // Then call our list of content, remove, and then remove content, because content should be on this list

            // Then we compare our initial count to the current count, and return true to our bool method 
            if(initialCount > _listOfContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }


        }





        // ----- HELPER METHOD ------ //


        // For both UPDATE and DELETE, because we are working with StreamingContent objects, we need to find the correct streaming content object that we are looking for
        // So we need to build a HELPER METHOD after all of our CRUD
        // If it's job is just to help the other methods, and NOT be an open accessable part, then we make it private to make part of this class only so that it cannot be accessed from the outside
        // If it's job is to be accessable to outsdie, then we make public ----- (ASK EFA'S HERE THE LIKELY SCNEARIOS THIS IS NEEDED) ------
        // So.... our goal with the below helper method is to get the correct streaming content based on some parameter
        // The below method will get streaming content based on the title parameter

        public StreamingContent GetContentByTitle(string title) // We have called the method, and been given title
        {
            // Now we need to find title in the _listofContent, however the list does not hold strings, it holds streaming content
            // So we will need to go through each streaming content, and check its title, to see if it is the correct one
            // We need to do this by iterating over the list, and we will do this with a foreach loop

            foreach(StreamingContent content in _listOfContent)     //This allows us to take of _listOfContent and iterate for each Streaming Content object in there, call it content, and then do the following
            {
                if(content.Title.ToLower() == title.ToLower()) // So if in the list content = title, then
                {
                    return content; // return that content object
                }

            }

            // What happens if we don't find the content? We need to close the loop by returning null if object is not found, I.e., we have to give it something even if it's not what we are looking for
            
            return null;

            // The reason WHY we BUILD the HELPER METHOD, is because in here we need to find the exact instance of the streaming content for our update and delete methods
            // Referencing our DELETE METHOD, we want to find a title to remove, we locate it, and then we remove the object, and if we remove it, let's go ahead an return a true or false value 
        }
         





    }
}

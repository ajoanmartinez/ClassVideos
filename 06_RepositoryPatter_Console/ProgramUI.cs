using _06_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _06_RepositoryPattern_Console
{  
    
    // Now that this UI class has been creaetd, we need a way to kickstart the application
    // The main method in Program.cs is the applications way of starting, but we want is a method in the UI that brings us to the UI code

    class ProgramUI
    {
        // CREATE FIELD HERE
        // We make the repository a field so that when our loop goes through and we call the create new content method and we add something to this field..
        // ... that when that method closes up all and all that code goes away, the _contentRepo is going to persist...
        // ... so, then after our create new content method we can call the _contentRepo.AddContenttoList() method and give it the StreamingConent object

        private StreamingContentRepository _contentRepo = new StreamingContentRepository();

        // Mehtod that runs/starts the UI part of the application
        public void Run()
        {
            // We want Run method to fire off once, and our Menu method is going to keep looping
            // We want to seed content list here
            SeedContentList(); // This method will fire off one time right before the menu runs
            Menu();
        }

        // Menu
        private void Menu()
        {
            // We want the user to select a menu option then come back to the menu and select a new option
            // So, we want to encapsulate all of our code inside our menu in a while loop, because we want the code to just run until a specific condition is met 
            bool keepRunning = true;
            while (keepRunning)
            {


                // Display options to the user

                Console.WriteLine("Select a menu option:\n" +
                  "1. Create New Content\n" +
                  "2. View All Content\n" +
                  "3. View Content by Title\n" +
                  "4. Update Existing Conetent\n" +
                  "5. Delete Existing Content\n" +
                  "6. Exit");

                // Get the user's input
                string input = Console.ReadLine(); // When we declare a variable and set it = to a method we are catching that return type, hence why we add "string input and set it = to Console.Readline();


                // Evaluate the user's input and act accordingly 
                switch (input)
                {
                    case "1":
                        // Create New Content
                        CreateNewContent();
                        break;
                    case "2":
                        // View All Content
                        DisplayAllContent();
                        break;
                    case "3":
                        // View content by Title
                        DisplayContentByTitle();
                        break;
                    case "4":
                        // Update Existing Content
                        UpdateExistingContent();
                        break;
                    case "5":
                        // Delete Existing Content
                        DeleteExistingContent();
                        break;
                    case "6":
                        // Exit
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }

                // It's not very pretty to have the terninal screen filling up with the menu each time the user selects a valid option 
                // Sooo.... we will use the Console.Clear inside our while loop so that it the screen clears after user's input and rewrites the screen

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey(); // This actually prompts the user to do the above Console.Write before it clears the screen
                Console.Clear(); // The problem with just leaving Console.Clear here is that it gets rid of our input, so enter prompt tondo something, we do this via Console.Writeline("Press any key to continue...")

                
            }

        }

        // Inside our class, but outside of all of our other methods, we need to write methods for each of our switch cases (i.e., menu options)
        // We want these methods to only be available from inside of the ProgramUI class so we make new private methods 
        // The below methods are void because we want them to do something but not return anything to the menu
        // When we call these methods we want to do something but they do not have to return anything to the menu




        // Create new StreamingContent
        private void CreateNewContent()
        {
            Console.Clear(); // Again allows us to clear the console so that the menus is cleared it looks as though the user is taken to a new page, Makes it easier for user to read and follow prompts


            // Need to be able to have content before we can display content, update and delete
            // Need to be able to create a new streaming content then fill out all of the properties of that streaming content based on the user's input
            // We cannot reference StremingContent until we add our 06_RepositoryPattern_Repository assembly so that we can reference the StreamingContent object 
            StreamingContent newContent = new StreamingContent();
            // The reason why we want to use this^^ as a blank conetent () is because later we want to call newContent.Title = "whatever the user enteres here", so instead of having to collect them all as... 
            // ..local variables we can just immediately assign that value once we get it from the user


            // We need to be able to get all of the following before we can have our streaming content:

            // Title
            Console.WriteLine("Enter the title for the content:"); // Prompt the user to enter the title for the content
            newContent.Title = Console.ReadLine(); // Then get that that title for that object


            // Description
            Console.WriteLine("Enter the description for the content:");
            newContent.Description = Console.ReadLine();


            // MaturityRating
            Console.WriteLine("Enter the rating for the conent (G, PG, PG-13, etc):");
            newContent.MaturityRating = Console.ReadLine();

            // StarRating -- Done differently than Title, Description, and MaturityRating, because StarRating type is a double 
            Console.WriteLine("Enter a star count for the content (5.8, 10, 1.5, etc):"); // The problem is now that the Console.Readline does not return a double, but we need a double
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString); // So we use the Parse method to convert the string to double 


            // IsFamilyFriendly -- Remember this is a boolean, so this is done differently from Title, Descriptin, NaturityRating AND StartRating, need to convert string to bool
            Console.WriteLine("Is this content family friendly? (y/n)");
            string familyFriendlyString = Console.ReadLine().ToLower();
            // Now we need to evaluate that string by running it through it a switch or an if else, For our purposes we will use if else
            if (familyFriendlyString == "y") // We are checking this against a lower case 'y', so we need to add .ToLower(); right after our Console.ReadLine, so that it sets capital 'Y' to 'y' for if else method
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;

            }



            // GenreType -- Remember this is an enum, so this will be different from Title, Description, MaturityRating, StarRating AND IsFamilyFriendly
            // There is a lot of different types, so we want to get the input of the different types of genre from the user, and then turn it into this enum
            // SEE 06_RepositoryPattern_Repository > StreamingContent.cs > Copy public enum GenreType > paste below to have something to reference

            /*
                Horror = 1,
                RomCom,
                SciFi,
                Documentary,
                Bromance,
                Drama,
                Action 
             */

            Console.WriteLine("Enter the Genre Number:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action");

            // Listing these ^^ in the same order so that their values match the same enum values in StreamingContent.cs in 06_RepositoryPattern_Repository

            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);
            // Next We Do Casting -- Take one object and cast it into a different type
            newContent.TypeOfGenre = (GenreType)genreAsInt; // Cannot set this equal to genreAsInt because that is the wrong type, so we cast with plugging GenreType in front of it


            // Now that we have all of our preoperties set we need to save that somewhere
            // We built our repository to have that list of content, _listOfContent with all of our methods
            // We need to go into program UI and call that repository and add it to the list 
            // We do NOT want to make a repository RIGHT HERE, because the same we we made in our repository we made our list a field so that all methods could use that same exact list....
            // ...we want to do the same in our program
            // SCROLL TO TOP OF PROGRAM UI AND CREATE A FIELD

            // CALL _contentRepo.AddContentToList() and give it newContent object that we just built with all it's properties that we just set and add to list 
            _contentRepo.AddContentToList(newContent);
            // We do not ever have to worry about the _contentRepo ever going away until we close out of the applicatoin

        }

        // View current StreamingContent that is saved
        private void DisplayAllContent()
        {
            Console.Clear();
            // First get the list 
            List<StreamingContent> listOfContent = _contentRepo.GetContentList(); // GetContentList is the method we built in the repository allowing us to pull the list from there, and save as _listOfContent
            // Now that we have the list, we want to show everything on the list 
            // We may not want all details, So we will show a lit of objects saying here's all the streaming content we have, and if you want to know more about it, look it up by its title
            foreach(StreamingContent content in listOfContent)
            {
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Desc: {content.Description}");
                // If in our terminal we call the DisplayAllContent method as it is written up to this point, it will do anything. Why?
                // The list is called, but there is nothing on the list, so when we call our for each loop it will not display anything because there is nothing on the list
                // The code works, so if we add something to the list, it will display something, but we would have to add soemthing before we could see something every time
                // We have 2 options
                // Recommendation is to add a method that seeds the database upon running so that we don't every time we run the application create something before we can manipulate it in any other way
                // We will do this by adding this method after our DeleteExistingContent() method
            }
        }

        // View existing Content by Title 
        private void DisplayContentByTitle()
        {
            Console.Clear();
            // Prompt user to give us a title
            Console.WriteLine("Enter the title of the content you'd like to see:");

            // Get the user's input
            string title = Console.ReadLine();

            // Find the content by that title
            StreamingContent content =_contentRepo.GetContentByTitle(title); // We need to save this, so we say we want a streaming content object called content and make it = to our... 
            //...  _contentRepo.GetContentByTitle(title) method

            // Display said content if it isn't null -- We will need to run some conditionals here
            if(content != null)
            {
                Console.WriteLine($"Title: {content.Title}\n" +
                   $"Desc: {content.Description}\n" +
                   $"Maturity Rating: {content.MaturityRating}\n" +
                   $"Stars: {content.StarRating}\n" +
                   $"IsFamilyFriendly: {content.IsFamilyFriendly}\n" +
                   $"GenreType: {content.TypeOfGenre}\n");                   
            }
            else
            {
                Console.WriteLine("No content by that title.");
            }

        }

        // Update Existing Content
        private void UpdateExistingContent()
        {
            // Display all content
            DisplayAllContent();

            // Ask for the title of content to update
            Console.WriteLine("\nEnter the title of the content you would like to udpate:");

            // Get that tile from user
            string oldTitle = Console.ReadLine();

            // We will build a new object -- Go steal the code from add new content, everything except Console.Clear and _contentRepo at the end of the create method
            StreamingContent newContent = new StreamingContent();
           
            // Title
            Console.WriteLine("Enter the title for the content:"); 
            newContent.Title = Console.ReadLine(); 


            // Description
            Console.WriteLine("Enter the description for the content:");
            newContent.Description = Console.ReadLine();


            // MaturityRating
            Console.WriteLine("Enter the rating for the conent (G, PG, PG-13, etc):");
            newContent.MaturityRating = Console.ReadLine();

            // StarRating -- double
            Console.WriteLine("Enter a star count for the content (5.8, 10, 1.5, etc):"); 
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString); 


            // IsFamilyFriendly -- boolean
            Console.WriteLine("Is this content family friendly? (y/n)");
            string familyFriendlyString = Console.ReadLine().ToLower();
         
            if (familyFriendlyString == "y") 
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;

            }

            // GenreType -- enum

            /*
                Horror = 1,
                RomCom,
                SciFi,
                Documentary,
                Bromance,
                Drama,
                Action 
             */

            Console.WriteLine("Enter the Genre Number:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action");

            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

           
            // Verify the update worked
           bool wasUpdated = _contentRepo.UpdateExistingContent(oldTitle, newContent);

            if (wasUpdated)
            {
                Console.WriteLine("Content succesfully updated!");
            }
            else
            {
                Console.WriteLine("Could not update content.");
            }


        }

        // Delete Existing Content 
        private void DeleteExistingContent()
        {
            // Before writing any other code for this method, go look at delete method in StreamingContentRepository

            // Before prompting the user to get the title they want to delete, we can call the display method to display all the content by titles available to be deleted
            DisplayAllContent(); // Since this method has the Console.Clear() method, and we are alling the DisplayAllContent method, then we do not need to add the clear method here in the delete method

            // Prompt user to get the title they want to delete
            Console.WriteLine("\nEnter the title of the content you would like to remove:");

            // We now need to capture that input
            string input = Console.ReadLine();

            // Call the delete method
            bool wasDeleted = _contentRepo.RemoveConetentFromList(input); // Since the method in the repository returns the boolean, we need to capture that boolean here

            // If the content was deleted, say so
            
            if (wasDeleted)
            {
                Console.WriteLine("The content was successfully deleted.");
            }
            else // -- Otherwise state it couldn't be deleted
            {
                Console.WriteLine("Content could not be deleted.");
            }


          
            

        }

        // Now that these methods are scaffolded out we want to go back to our switch method and call these methods 



        // See Method -- This is will be a list that gets called where it will seed the content list so it will have some stuff on there
        private void SeedContentList()
        {
            // Fill out a few streaming content objects and add them to the list

            StreamingContent sharknado = new StreamingContent("Sharknado", "Tornados, but with sharks.", "TV-14", 3.3, true, GenreType.Action);
            StreamingContent theRoom = new StreamingContent("The Room", "Bakner's life gest turned upside down.", "R", 3.7, false, GenreType.Drama);
            StreamingContent rubber = new StreamingContent("Rubber", "Car tire comes to life and goes on killing spree.", "R", 5.8, false, GenreType.Documentary);

            // After we have filled out a few streaming content objects, we now want to call our streaming content repository
            _contentRepo.AddContentToList(sharknado);
            _contentRepo.AddContentToList(theRoom);
            _contentRepo.AddContentToList(rubber);

            // Now we need to call SeedContetList method, We see we have zero references, nothing is being referenced in the method
            // SCROLL BACK UP TO THE TOP TO RUN METHOD

        }

    }
}

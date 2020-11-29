using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPatter_Console

    // It's time to build the console app now that the repository and tests are built out
    // Console app is the front-end that will directly interact with the user
    // All other code up to this point is built out to do the behind the scenes work
    // All other code has inputs and outputs, but does not collect input from a user, and this intentional
    // The responsiblity of our repository is to do the manipulation that our data needs
    // The responsiblity of our UI (or Console App in this case) is to interact with the user and to make sure that the user's input gets to the correct spot
{
    class Program
    {
        // The below static void main method is the entry to the application, so when the application runs, Main is the first thing to fire off
        // Considering the Single Responsibility principle, what is the responsiblity of the Main method?
        // We will make new class called Program UI which will hold all of our methods related to the UI the same way repository holds all the methods to maniuplating streaming content collection
        // First we add a class called ProgramUI
        static void Main(string[] args) 
        {
            ProgramUI program = new ProgramUI();
            program.Run();
        }
    }
}

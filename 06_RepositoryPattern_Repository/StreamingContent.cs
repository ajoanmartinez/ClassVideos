using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    // Plain Old C# Object -- POCO
    // It's a simple, single repository that just holds data
    // We need to define what data it's going to hold
    // We need some properties and some constructors to define what data it's going to hold 


    public enum GenreType
    {
        Horror = 1,
        RomCom,
        SciFi,
        Documentary,
        Bromance,
        Drama,
        Action 

            // Note that when hovering over the list in Enum, intellisense shows a numerical value that has been assigned in the background
            // In the list above "Horror", assigigning the value of 1, which then in turn reassigns a the values of the rest of the items in the list in force ranked order
            // If we remove the value we have assigned to "Horror", then we will see by hovering over the each item in list that the values have been automatically assigned in the background starting at Horror = 0
            // Essentially chaing 0 indexed to to 1
    }
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string MaturityRating { get; set; }
        public double StarRating { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public GenreType TypeOfGenre { get; set; } // Note on naming convention here: property type (GenreType), value of property type (TypeOfGenre), flip order of name because cannot name the same
        public StreamingContent() { } // Empty constructor
        public StreamingContent(string title, string description, string maturityRating, double starRating, bool isFamilyFriendly, GenreType genre)
        {
            // In here we are going to take all of these^^ parameters and assign them to our properties
            // IMPORTANT SCOPE NOTE: constructors below, and the properties above are siblings because they exist in the same class "StreamingContent", so they can see each other
            // However, the parameters defined in the constructor public StreamingContent (title, descprtion, maturityRating, startRating, isFamily, genre) so we cannot use these parameters in the other constructor..
            // ..in the class, because it does not exist in that context. I.e., we cannot start with the parameters and work outward, we can on start outward, and drill down inward. 

            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            IsFamilyFriendly = isFamilyFriendly;
            TypeOfGenre = genre;

        }


    }
}

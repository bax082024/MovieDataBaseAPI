

namespace MovieDataBaseAPI.controllers
{
    public class Movie 
    {
        public string Title {get; set;}
        public string Lenght { get; set;} // Lenght of the movie

        public Movie(string title, string lenght)
        {
            Title = title;
            Lenght = lenght;
        }
    }
}
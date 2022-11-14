﻿namespace JokingApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }
        public DateTime Date { get {return DateTime.Now;}}
        public Joke()
        {

        }
    }
}

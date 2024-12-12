namespace TumakovLab.Classes
{
    public class Song
    {
        public string name; 
        public string author; 
        public Song prev; 
        
        public void SetName(string songName)
        {
            name = songName;
        }
        
        public void SetAuthor(string songAuthor)
        {
            author = songAuthor;
        }
        
        public void SetPrev(Song previousSong)
        {
            prev = previousSong;
        }
        
        public void Print()
        {
            Console.WriteLine($"{name} - {author}");
        }
        
        public string Title()
        {
            return $"{name} - {author}";
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Song other = (Song)obj;
            return name == other.name && author == other.author;
        }
    }

}

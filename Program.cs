using SQLite;

Console.WriteLine("Hello, World!");
// cONNESSIONE AL DB   // pcl non pc1
SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
var tbArtist = cn1.Query<Artist>("select* from artists");
Console.WriteLine($"In questa tabella ci sono {tbArtist.Count}record!");
//fine del main.... inizio della dichiarazione
public class Artist
{
   public int ArtistId{get;set;}

   public string? Name {get;set;}
    
} 

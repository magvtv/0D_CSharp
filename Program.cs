using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;


class Artwork
{
    public string Title { get; set; }
    public string Summary { get; set; }
}

class Artist
{
    public string Name { get; set; }
    public Dictionary <string, Artwork> Artworks { get; set; }
    public Artist(string name)
    {
        Name = name;
        Artworks = new Dictionary<string, Artwork>();
    }

    public void AddArtwork (string title, string summary)
    {
        Artworks[title] = new Artwork { Title = title, Summary = summary };
    }
}


class Renaissance
{
    private Dictionary<string, Artist> artists;
    public Renaissance()
    {
        artists = new Dictionary<string, Artist> ();
    }

    public void AddArtist()
    {
        
    }

    public void AddArtwork()
    {

    }
    public void ShowGallery()
    {
        Console.WriteLine("My Renaissance Art Gallery");

    }
}
class Program
{
    
    public static void Main(string[] args)
    {

        string[] artists = {
            "Leonardo Da Vinci",
            "Michelangelo",
            "Raphael",
            "Donatello",
            "Titian",
            "Sandro Botticelli",
            "El Greco",
            "Caravaggio",
            "Hieronymus Bosch",
        };

        Queue <int> artworksTotal = new Queue<int>();
        artworksTotal.Enqueue(20);
        artworksTotal.Enqueue(40);
        artworksTotal.Enqueue(60);
        artworksTotal.Enqueue(30);
        artworksTotal.Enqueue(100);
        artworksTotal.Enqueue(50);
        artworksTotal.Enqueue(120);
        artworksTotal.Enqueue(80);
        artworksTotal.Enqueue(25);


        for(int x = 0; x < artists.Length; x++)
        {
            Console.WriteLine(artists[x]);
        }

        // Dictionary <string, int> renaissance = new Dictionary <string, int> ();
        // renaissance.Add("Leonardo", 20);
        // renaissance.Add("Michelangelo", 40);
        // renaissance.Add("Raphael", 60);
        // renaissance.Add("Donatello", 30);
        // renaissance.Add("Titian", 100);
        // renaissance.Add("Sandro Botticelli", 50);
        // renaissance.Add("El Greco", 120);
        // renaissance.Add("Caravaggio", 80);
        // renaissance.Add("Hieronymus Bosch", 25);


    }
}
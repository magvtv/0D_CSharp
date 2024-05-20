using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;



namespace Renaissance
{
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

        public void AddArtwork(string title, string summary)
        {
            Artworks[title] = new Artwork { Title = title, Summary = summary };
        }
    }


    class Renaissance
    {
        private Dictionary<int, Artist> artists;
        private int nextArtistKey = 0;
        public Renaissance()
        {
            artists = new Dictionary<int, Artist> ();
        }

        public int AddArtist(string name)
        {
            // check whether there is any existing name similar to the input
            artists[nextArtistKey] = new Artist(name);
            Console.WriteLine($"Successfully added {name} (key: {nextArtistKey})");
            return nextArtistKey++;
        }

        public void AddArtwork(int artistKey, string title, string summary)
        {
            if(artists.TryGetValue(artistKey, out Artist artist))
            {
                artist.AddArtwork(title, summary);
                Console.WriteLine($"Added the '{title}' by {artist.Name}");
            }
            else
            {
                Console.WriteLine($"Artist with key {artistKey} not found.");
            }

        }
        public void ShowGallery()
        {
            Console.WriteLine("Renaissance Art Gallery");
            foreach (var person in artists)
            {
                Console.WriteLine($"Artist: {person.Value.Name}");
                foreach (var piece in person.Value.Artworks)
                {
                    Console.WriteLine($"Artwork:\n- {piece.Key}\n{piece.Value.Summary}");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Renaissance gallery = new Renaissance();
            Console.Write($"How many artists into the gallery? ");
            int numArtist = int.Parse(Console.ReadLine());
            for(int x = 0; x < numArtist; x++)
            {
                Console.Write($"{x + 1}.Enter artist\'s name: ");
                string artistName = Console.ReadLine();
                gallery.AddArtist(artistName);
            }

            Console.WriteLine($"Enter number of artworks to insert: ");
            int numArtworks = int.Parse(Console.ReadLine());

            for(int y = 0; y < numArtworks; y++)
            {
                Console.Write($"Enter the artist key: ");
                int artistKey = int.Parse(Console.ReadLine());
                Console.Write($"{y + 1}.Enter title of the artwork: ");
                string artworkTitle = Console.ReadLine();
                Console.WriteLine($"Enter summary of {artworkTitle}:");
                string artworkSummary = Console.ReadLine();
                gallery.AddArtwork(artistKey, artworkTitle, artworkSummary);
            }
            gallery.ShowGallery();
        }
    // public static void Main(string[] args)
    // {

    //     string[] artists = {
    //         "Leonardo Da Vinci",
    //         "Michelangelo",
    //         "Raphael",
    //         "Donatello",
    //         "Titian",
    //         "Sandro Botticelli",
    //         "El Greco",
    //         "Caravaggio",
    //         "Hieronymus Bosch",
    //     };

    //     Queue <int> artworksTotal = new Queue<int>();
    //     artworksTotal.Enqueue(20);
    //     artworksTotal.Enqueue(40);
    //     artworksTotal.Enqueue(60);
    //     artworksTotal.Enqueue(30);
    //     artworksTotal.Enqueue(100);
    //     artworksTotal.Enqueue(50);
    //     artworksTotal.Enqueue(120);
    //     artworksTotal.Enqueue(80);
    //     artworksTotal.Enqueue(25);


    //     for(int x = 0; x < artists.Length; x++)
    //     {
    //         Console.WriteLine(artists[x]);
    //     }

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

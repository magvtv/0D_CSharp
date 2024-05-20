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
        private Dictionary<string, Artist> artists;
        public Renaissance()
        {
            artists = new Dictionary<string, Artist> ();
        }

        public void AddArtist(string name)
        {
            // check whether there is any existing name similar to the input
            if(!artists.ContainsKey(name))
            {
                artists[name] = new Artist(name);
                Console.WriteLine($"Successfully added {name}");
            }
            else
            {
                Console.WriteLine($"{name} already exists");
            }
        }

        public void AddArtwork(string artistName, string title, string summary)
        {
            if(artists.TryGetValue(artistName, out Artist artist))
            {
                artist.AddArtwork(title, summary);
                Console.WriteLine($"Successfully added the '{title}' by {artistName}");
            }
            else
            {
                Console.WriteLine($"Could not find {artist}");
            }

        }
        public void ShowGallery()
        {
            Console.WriteLine("Renaissance Art Gallery");
            foreach(var person in artists)
            {
                Console.WriteLine($"Artist: {person.Value.Name}");
                foreach(var piece in person.Value.Artworks)
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
            gallery.AddArtist("Leonardo da Vinci");
            gallery.AddArtist("Sandro Botticelli");
            gallery.AddArtist("Michelangelo");

            gallery.AddArtwork("Leonardo da Vinci", "Mona Lisa", "The potrait bears strong resemblance to the Virgin Mary - who was seen as an ideal for womanhood");
            gallery.AddArtwork("Sandro Botticelli", "Primavera", "Large panel tempera painting depicting figures from mythology");
            gallery.AddArtwork("Michelangelo", "David", "A colossal masterpiece sculpture made of marble");
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

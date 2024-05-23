using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using HtmlAgilityPack;
using RenaissanceAPI.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RenaissanceAPI.Services
{
    public class WikipediaService
    {
  
        private readonly HttpClient _httpClient;
        public WikipediaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");

        }

        public async Task<Artist> ScrapeArtistData(string name)
        {
            var url = $"https://en.wikipedia.org/wiki/{name}";
            var html = await _httpClient.GetAsync(url);
            var doc = new HtmlDocument();
            doc.LoadHtml(html);


            var artist = new Artist
            {
                Name = name,
                Summary = summary,
                WikipediaUrl = url
            }

            return artist;
        }

        public async Task<Artwork> ScrapeArtworkData(string title)
        {
            var url = $"https://en.wikipedia.org/wiki/{name}";
            var html = await _httpClient.GetAsync(url);
            var doc = new HtmlDocument();
            doc.LoadHtml(html);


            var artwork = new Artwork
            {
                Name = name,
                Details = details,
                WikipediaUrl = url
            }

            return artwork;
        }

        private string GetDescription(Html doc)
        {
            var descriptionNode = doc.DocumentNode.SelectSingleNode("//p[not(@class]");
            return descriptionNode?.InnerText.Trim() ?? "Description not found!";
        }
    }
}
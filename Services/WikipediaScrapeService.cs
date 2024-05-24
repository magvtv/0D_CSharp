using HtmlAgilityPack;

public class WikipediaScrapeService
{
    private readonly HttpClient _httpClient;

    public WikipediaScrapeService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");
    }

    public async Task<Artist> ScrapeArtistData(string artistName)
    {
        var artistUrl = $"https://en.wikipedia.org/wiki/{artistName.Replace(" ", "_")}";
        var response = await _httpClient.GetStringAsync(artistUrl);
        var htmlDoc = new HtmlDocument();
        htmlDoc.LoadHtml(response);

        var artist = new Artist
        {
            Name = artistName,
            Summary = GetSummary(htmlDoc),
            WikipediaUrl = artistUrl,
        };
        return artist;
    }

    public async Task<Artwork> ScrapeArtworkData(string artworkTitle)
    {
        var artworkUrl = $"https;//en.wikipedia.org/wiki/{artworkTitle.Replace(" ", "_")}";
        var response = await _httpClient.GetStringAsync(artworkUrl);
        var htmlDoc = new HtmlDocument();
        htmlDoc.LoadHtml(response);

        var artwork = new Artwork
        {
            Title = artworkTitle,
            Details = GetSummary(htmlDoc),
            WikipediaUrl = artworkUrl
        };
        return artwork;
    }

    private string GetSummary(HtmlDocument htmlDoc)
    {
        var summaryNode = htmlDoc.DocumentNode.SelectSingleNode("//p");
        return summaryNode != null ? summaryNode.InnerText.Trim() : "Summary not available";
    }
}
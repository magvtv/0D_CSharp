using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]

public class WikipediaController : ControllerBase
{
    private readonly WikipediaScrapeService _scrapeService;
    public WikipediaController(WikipediaScrapeService scrapeService)
    {
        _scrapeService = scrapeService;
    }

    [HttpGet("artist/{artistName}")]
    public async Task<IActionResult> GetArtist(string artistName)
    {
        var artist = await _scrapeService.ScrapeArtistData(artistName);
        return Ok(artist);
    }

    [HttpGet("artwork/{artworkTitle}")]
    public async Task<IActionResult> GetArtwork(string artworkTitle)
    {
        var artwork = await _scrapeService.ScrapeArtworkData(artworkTitle);
        return Ok(artwork);
    }
}
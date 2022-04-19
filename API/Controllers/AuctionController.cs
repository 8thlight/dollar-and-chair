using Microsoft.AspNetCore.Mvc;
using Application.Models;
using Application.Services;

namespace API.Controllers;

[ApiController]
[Route("Auctions")]
public class AuctionController : ControllerBase
{
    private IAuctionService auctionService;

    public AuctionController(IAuctionService auctions)
    {
        auctionService = auctions;
    }
    
    [HttpGet("allAuctions")]
    public IList<Auctions> GetAuctions()
    {
        return auctionService.Auctions();
    }
}
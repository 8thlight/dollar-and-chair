using Microsoft.AspNetCore.Mvc;
using Application.Models;
using Application.Services;

namespace API.Controllers;

[ApiController]
[Route("auctions")]
public class AuctionController : ControllerBase
{
    private IAuctionService auctionService;

    public AuctionController(IAuctionService auctions)
    {
        auctionService = auctions;
    }
    
    [HttpGet("")]
    public GetAllAuctionsResult GetAuctions()
    {
        return auctionService.GetAllAuctions();
    }
}
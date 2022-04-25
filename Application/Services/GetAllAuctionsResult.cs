using Application.Models;

namespace Application.Services;

public class GetAllAuctionsResult
{
    public List<Auctions> Auctions { get; set; }
    public bool AllowedToEditAuctions { get; set; }
}
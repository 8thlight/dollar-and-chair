using Application.Services;
using NUnit.Framework;
namespace Tests.ApplicationTest;

public class AuctionServiceTest
{
    private AuctionService auctionService;
    
    [SetUp]
    public void Setup()
    {
        auctionService = new AuctionService();
    }

    [Test]
    public void ShouldHaveTotalOfFiveAuctions()
    {
        var result = auctionService.GetAllAuctions();
        
        Assert.AreEqual(result.Auctions.Count, 5, "This does not contain 5 records");
    }

    [Test]
    public void EachAuctionShouldContainAMaxNumberOfSeatsOfFive()
    {
        var result = auctionService.GetAllAuctions();
        
        foreach (var auction in result.Auctions)
            Assert.AreEqual(auction.MaxSeats, 5, "It does not contain 5 seats");
    }
}
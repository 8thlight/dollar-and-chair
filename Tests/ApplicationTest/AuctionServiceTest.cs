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
        var result = auctionService.Auctions();
        
        Assert.AreEqual(result.Count, 5, "This does not contain 5 records");
    }

    [Test]
    public void EachAuctionShouldContainAMaxNumberOfSeatsOfFive()
    {
        var result = auctionService.Auctions();
        
        foreach (var auction in result)
            Assert.AreEqual(auction.MaxSeats, 5, "It does not contain 5 seats");
    }
}
using System;
using Application.Models;
namespace Application.Services;

public class AuctionService : IAuctionService 
{
    public GetAllAuctionsResult GetAllAuctions()
    {
        var result = new GetAllAuctionsResult();
        result.Auctions = new List<Auctions>();
// creates dummy data
        for(var i = 1; i <= 5; i++)
        {
            var auction = new Auctions
            {
                Id = RandomNumber(),
                StartingPrice = RandomPrice(500.00, 1000.00),
                StartDate = DateTime.Now.AddDays(5),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now.AddDays(i),
            };

            auction.ExpirationDate = auction.StartDate.AddDays(RandomNumber());

            result.Auctions.Add(auction);
        }

        return result;
    }
    private int RandomNumber()
    {
        return new Random().Next(100);
    }
    
    private double RandomPrice(double min, double max)
    {
        Random random = new Random();
        return random.NextDouble() * (max - min) + min;
    }
    
}
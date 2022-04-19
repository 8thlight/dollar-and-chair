using System;
using Application.Models;
namespace Application.Services;

public interface IAuctionService
{
    IList<Auctions> Auctions();
}
public class AuctionService : IAuctionService 
{
    public IList<Auctions> Auctions()
    {
        DateTime eventDate = DateTime.Now.AddDays(5);
        
        return Enumerable.Range(1, 5).Select(index => new Auctions
        {
            Id = RandomNumber(),
            StartingPrice = RandomPrice(500.00, 1000.00),
            StartDate = eventDate,
            ExpirationDate = eventDate.AddDays(RandomNumber()),
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now.AddDays(index),
            
            
        })
        .ToList();
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
namespace Application.Models;

public class Auctions
{
    public  int Id { get; set; }
    public Double StartingPrice { get; set; }
    public int MaxSeats => 5;
    public DateTime StartDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
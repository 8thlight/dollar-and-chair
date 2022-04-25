using API.Controllers;
using Application.Models;
using Application.Services;
using AutoMoqCore;
using Moq;
using NUnit.Framework;
namespace Tests.APITest;

public class AuctionControllerTest
{
    private AuctionController controller;
    private Mock<IAuctionService> mockAuctionService;
    
    [SetUp]
    public void Setup()
    {
        var mocker = new AutoMoqer();
        
        mockAuctionService = mocker.GetMock<IAuctionService>();
        controller = new AuctionController(mockAuctionService.Object);
    }

    [Test]
    public void Pass()
    {
        // Arrange
        mockAuctionService.Setup(a => a.GetAllAuctions()).Returns(new GetAllAuctionsResult
        {
            AllowedToEditAuctions = true
        });
        
        // Act
        var result = controller.GetAuctions();
        
        // Assert
        Assert.AreEqual(result.AllowedToEditAuctions, true, "You are not allowed to edit results");
    }
}
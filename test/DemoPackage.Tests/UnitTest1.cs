using TestPackage2;

namespace DemoPackage.Tests;

public class UnitTest1
{
    [Fact]
    public void Should_SendPingRequest_RespondPong()
    {
        // Arrange
        var pingRequest = new PingRequest();

        // Act
        var result = pingRequest.Send();

        // Assert
        Assert.Equal("Pong", result);
    }
}
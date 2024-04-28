namespace TestPackage4;

public class PingRequest
{
    public string Send() => "Pong";
    
     public Task<string> SendAsync() => Task.FromResult("Pong");
}
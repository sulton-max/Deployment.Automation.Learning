namespace DemoPackage;

public class PingRequest
{
    public string Send() => "Pong";
    
    public ValueTask<string> SendAsync() => ValueTask.FromResult("Pong");
    
}
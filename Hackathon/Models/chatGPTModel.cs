namespace Hackathon.Models;

public class chatGPTModel
{
    public string? Prompt { get; set; }
    public int MaxTokens { get; set; } = 100;
    public float Temperature { get; set; } = 0.5f;
}

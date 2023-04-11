using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using OpenAI_API;
using Hackathon.Models;

namespace Hackathon.Controllers;

public class chatGPT : Controller
{
    [Route("promptText")]
    [HttpPost]
    public IActionResult promptText(chatGPTModel chatGPT)
    {
        var openai = new OpenAIAPI("chatGPTkey");
        var completions = openai.Completions.CreateCompletionAsync(
            prompt: chatGPT.Prompt,
            model: "text-davinci-002",
            max_tokens: chatGPT.MaxTokens,
            temperature: chatGPT.Temperature
        );
        var response = string.Empty;
        foreach (var completion in completions.Result.Completions)
        {
            response += completion.Text;
        }
        return Ok(response);
    }
}

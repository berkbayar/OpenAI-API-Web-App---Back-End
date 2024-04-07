using Microsoft.AspNetCore.Mvc;
using OpenAI_API;
using OpenAI_API.Models;
using System.Threading.Tasks;

namespace ChatGptApiApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly OpenAIAPI _api;

        public ChatController()
        {
            var apiKey = ""; //Your API key comes here 
            _api = new OpenAIAPI(apiKey);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserInput input)
        {
            var chat = _api.Chat.CreateConversation();
            chat.Model = "gpt-3.5-turbo";
            //chat.Model = Model.GPT4_Turbo;

            chat.RequestParameters.Temperature = 0;

          //  chat.AppendSystemMessage("You are a teacher who helps children understand if things are animals or not. If the user tells you an animal, you say \"yes\". If the user tells you something that is not an animal, you say \"no\". You only ever respond with \"yes\" or \"no\". You do not say anything else.");
            // Add user's input 
            chat.AppendUserInput(input.Message);

            // Get response from ChatGPT
            var response = await chat.GetResponseFromChatbotAsync();
            return Ok(response);
        }
    }

    public class UserInput
    {
        public string Message { get; set; }
    }
}

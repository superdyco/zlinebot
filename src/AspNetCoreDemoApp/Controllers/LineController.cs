using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Formatting;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemoApp.Controllers
{
    [Route("api/[controller]")]
    public class LineController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post()
        {
            var token = isRock.LineBot.Utility.IssueChannelAccessToken("1498316698", "88174c78200836cc10f05f5d3aae63d5");
            try
            {
                //取得 http Post RawData(should be JSON)
                string postData = new StreamReader(Request.Body).ReadToEnd();
                //剖析JSON
                var ReceivedMessage = isRock.LineBot.Utility.Parsing(postData);
                //回覆訊息
                string Message;
                Message = "你說了:" + ReceivedMessage.events[0].message.text;
                //回覆用戶
                isRock.LineBot.Utility.ReplyMessage(ReceivedMessage.events[0].replyToken, Message, token.access_token);
                //回覆API OK
                return Ok();
            }
            catch (Exception ex)
            {
                return Ok();
            }
        }
    }
}
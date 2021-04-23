using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotTest.Commands
{
    public class TestCommand : Command
    {
        protected override string[] names { get; set; } = { "test" };

        public override async void Execute(Message message, TelegramBotClient client)
        {
            await client.SendTextMessageAsync(message.Chat.Id, "TEST");
        }
    }
}

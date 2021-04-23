using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotTest
{
    public abstract class Command
    {
        protected abstract string[] names { get; set; }

        public abstract void Execute(Message message, TelegramBotClient client);

        public bool Contains(string messageText)
        {
            foreach(string name in this.names)
            {
                if (messageText.StartsWith(name))
                    return true;
            }

            return false;
        }
    }
}

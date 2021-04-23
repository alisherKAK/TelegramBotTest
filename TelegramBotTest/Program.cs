using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBotTest.Commands;

namespace TelegramBotTest
{
    class Program
    {
        private static TelegramBotClient client;
        private static List<Command> commands = new List<Command>();
        static void Main(string[] args)
        {
            client = new TelegramBotClient("1702352315:AAEF-uF57wdv-QgIJF6beS4ZCthytG4f2S0");
            client.StartReceiving();

            commands.Add(new TestCommand());

            client.OnMessage += ClientMessageHandle;

            Console.ReadLine();
        }

        private static void ClientMessageHandle(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            Message message = e.Message;
            if (message == null)
                return;

            foreach(Command command in commands)
            {
                if (command.Contains(message.Text))
                    command.Execute(message, client);
            }
        }
    }
}

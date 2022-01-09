using System;
using Telegram.Bot;

namespace TelegramShell
{
    public class TelegramAPI
    {
        private string _token;
        public TelegramBotClient Client { get; }

        public TelegramAPI()
        {
            EnvFile env = new EnvFile( @"Enviroments\.env");
            env.Load();

            _token = Environment.GetEnvironmentVariable("API_KEY");

            Client = new TelegramBotClient(_token);
        }
    }
}
using System.Collections.Generic;
using TelegramShell.CommandsImplementation;

namespace  TelegramShell.Commands
{
    public class Show : ICommand
    {
        public bool IsMatch(string command) 
            => nameof(Show) == command;

        public void Execute(List<string> arguments, TelegramAPI api, long chatId)
        {
            ShowImplementation showImplementation = new ShowImplementation();
            string listOfCommands = showImplementation.PrintCommandList();
            api.Client.SendTextMessageAsync(chatId, listOfCommands);
        }
    }
}
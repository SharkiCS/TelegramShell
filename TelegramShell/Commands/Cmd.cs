using System.Collections.Generic;
using TelegramShell.CommandsImplementation;

namespace  TelegramShell.Commands
{
    public class Cmd : ICommand
    {
        public bool IsMatch(string command) 
            => nameof(Cmd) == command;

        public void Execute(List<string> arguments, TelegramAPI api, long chatId)
        {
            CmdImplementation cmdImplementation = new CmdImplementation();
            string output = cmdImplementation.ExecuteAsync(arguments).Result;
            api.Client.SendTextMessageAsync(chatId, output);
        }
    }
}
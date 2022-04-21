using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TelegramShell.CommandsImplementation;

namespace  TelegramShell.Commands
{
    public class Chat : ICommand
    {
        public bool IsMatch(string command) 
            => nameof(Chat) == command;

        public void Execute(List<string> arguments, TelegramAPI api, long chatId)
        {
            api.Client.StopReceiving();
            
            ChatImplementation chat = new ChatImplementation(
               mainApi: api,
               nickName: arguments.Count > 0 ?
                   arguments.First() :
                   "Unknown"
                );
            
            Application.Run(chat);
        }
    }
}
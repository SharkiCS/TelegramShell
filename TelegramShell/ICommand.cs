using System.Collections.Generic;

namespace TelegramShell
{
    public interface ICommand
    {
        bool IsMatch(string command);
        void Execute(List<string> arguments, TelegramAPI api, long chatId);
    }
}
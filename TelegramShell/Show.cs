using System;
using System.Text;

namespace TelegramShell
{
    public class Show : ICommand
    {
        public string Execute()
        {
            StringBuilder listOfCommands = new StringBuilder();

            foreach (var command in (Commands[]) Enum.GetValues(typeof(Commands)))
            {
                if(command.ToString() == "NotValidCommand")  
                    continue;
                
                listOfCommands.Append($"/{command}\n");
            }

            return listOfCommands.ToString();
        }

        public string IsMatch() => nameof(Show);
    }
}
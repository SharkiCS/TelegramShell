using System;
using System.Collections.Generic;
using System.Linq;

namespace TelegramShell
{
    public class Command
    {
        private readonly string _command;
        private readonly List<String> _parameters;

        public Command(string message)
        {
            _parameters = message.Split(' ').ToList();
            _command = _parameters.First();
            _parameters.RemoveAt(0);
        }
        
        public Commands GetCommand()
        {
            if (!_command.StartsWith('/') || 
                !Enum.TryParse<Commands>(_command[1..], false, out Commands commands))
                return Commands.NotValidCommand;

            return (Commands)Enum.Parse(typeof(Commands), _command[1..]);
        }

        public List<String> GetParameters() => _parameters;
    }
}
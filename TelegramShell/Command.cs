using System.Collections.Generic;
using System.Linq;

namespace TelegramShell
{
    public class Command
    {
        public List<string> Arguments { get; }
        public string Name { get; }

        public Command(string message)
        {
            Arguments = message.Split(' ').ToList();
            Name = Arguments.First().Substring(1, Arguments.First().Length -1);
            Arguments.RemoveAt(0);
        }
    }
}
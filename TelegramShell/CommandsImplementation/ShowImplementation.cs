using System.Collections.Generic;

namespace TelegramShell.CommandsImplementation
{
    public class ShowImplementation
    {
        private List<string> commandList = new()
        {
            "/Show",
            "/Cmd",
            "/Chat"
        };
        
        public string PrintCommandList()
            => string.Join('\n', commandList);
    }
}
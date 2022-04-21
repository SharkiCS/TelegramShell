using System;
using System.Collections.Generic;
using System.Text;

namespace TelegramShell
{
    public class ShowImplementation
    {
        private List<string> commandList = new()
        {
            "/Show",
            "/Cmd",
            "Chat"
        };
        
        public string PrintCommandList()
            => string.Join('\n', commandList);
    }
}
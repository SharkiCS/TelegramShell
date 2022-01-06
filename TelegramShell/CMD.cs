using System;
using System.Collections.Generic;

namespace TelegramShell
{
    public class CMD
    {
        private readonly string _command;
        public CMD(List<String> command) =>
            _command = String.Join(' ', command);

        public string Execute()
        {
            try
            {
                System.Diagnostics.Process CMD = new System.Diagnostics.Process();
                CMD.StartInfo.FileName = "cmd.exe";
                CMD.StartInfo.Arguments = @"/c " + _command;
                CMD.StartInfo.UseShellExecute = false;
                CMD.StartInfo.CreateNoWindow = true;
                CMD.StartInfo.RedirectStandardOutput = true;
                CMD.Start();
                
                string output = CMD.StandardOutput.ReadToEnd();

                return output.Length > 0 ? $"{output.Trim()}" : "Output can't be showed.";
            }
            catch
            {
                return "Cmd command isn't correct";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TelegramShell
{
    public class CMD
    {
        private readonly string _command;
        public CMD(List<String> command) =>
            _command = String.Join(' ', command);
        
        public async Task<string> Execute()
        {
            StringBuilder output = new StringBuilder();
            Process terminal = Process.Start(new ProcessStartInfo("cmd.exe")
            {
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                Arguments = @"/c " + _command,
                UseShellExecute = false,
            });

            terminal.OutputDataReceived += (s, e) => output.Append(e.Data);
            terminal.Start();
            terminal.BeginOutputReadLine();
            
            CancellationTokenSource timeoutSignal = new(TimeSpan.FromSeconds(5));
            
            try
            {
                await terminal.WaitForExitAsync(timeoutSignal.Token);
                return $"Command finished sucessfully.\n{output}";
            } 
            catch (OperationCanceledException)
            {
                terminal.Kill();
                return $"Command exited due to out of time.\n{output}";
            }
        }
    }
}
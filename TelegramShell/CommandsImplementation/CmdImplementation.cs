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
        private async Task<string> ExecuteAsync(List<string> arguments)
        {
            StringBuilder output = new StringBuilder();
            Process terminal = Process.Start(new ProcessStartInfo("cmd.exe")
            {
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                Arguments = @"/c " + string.Join(' ', arguments),
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
        public string Execute(List<string> arguments) 
            => ExecuteAsync(arguments).Result;
        public bool IsMatch(string command) 
            => nameof(ShowImplementation) == command;
    }
}
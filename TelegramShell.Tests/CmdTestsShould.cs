using Xunit;
using FluentAssertions;

namespace TelegramShell.Tests
{
    public class CmdTestsShould
    {
        [Fact]
        public void ReturnsCommandFinishedSuccessfullyPlusOutput()
        {
            Command command = new Command("/CMD echo prueba");
            CMD cmd = new CMD(command.GetParameters());
            cmd.Execute().Result.Should().Be("Command finished sucessfully.\nprueba");
        }
        
        [Fact]
        public void ReturnsOutOfTimeMessagePlusOutput()
        {
            Command command = new Command("/CMD ftp");
            CMD cmd = new CMD(command.GetParameters());
            cmd.Execute().Result.Should().Be("Command exited due to out of time.\n");
        }
    }
}   
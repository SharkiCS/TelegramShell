using Xunit;
using FluentAssertions;
using TelegramShell.CommandsImplementation;

namespace TelegramShell.Tests
{
    public class CmdTestsShould
    {
        [Fact]
        public void ReturnsCommandFinishedSuccessfullyPlusOutput()
        {
            Command command = new Command("/CMD echo prueba");
            CmdImplementation cmdImplementation = new CmdImplementation(command.GetParameters());
            cmdImplementation.Execute().Result.Should().Be("Command finished sucessfully.\nprueba");
        }
        
        // [Fact]
        // public void ReturnsOutOfTimeMessage()
        // {
        //     Command command = new Command("/CMD ftp");
        //     CMD cmd = new CMD(command.GetParameters());
        //     cmd.Execute().Result.Should().Be("Command exited due to out of time.\n");
        // }
    }
}   
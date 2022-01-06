using Xunit;
using FluentAssertions;

namespace TelegramShell.Tests
{

    public class CmdTests
    {
        [Fact]
        public void EchoOneShowOneAsString()
        {
            Command command = new Command("/CMD echo 1");
            CMD cmd = new CMD(command.GetParameters());
            cmd.Execute().Should().Be("1");
        }
    }
}
using Xunit;
using FluentAssertions;

namespace TelegramShell.Tests
{
    public class CommandTests
    {
        [Fact]
        public void GetCommandReturnTheCommandEnumIfExists()
        {
            Command command = new Command("/Show echo 1");
            command.GetCommand().Should().Be(Commands.Show);
        }
        
        [Fact]
        public void GetCommandReturnNotValidCommandIfDoesntExist()
        {
            Command command = new Command("/testing");
            command.GetCommand().Should().Be(Commands.NotValidCommand);
        }
    }
}
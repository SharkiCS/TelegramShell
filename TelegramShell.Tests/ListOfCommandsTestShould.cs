using Xunit;
using FluentAssertions;
using TelegramShell.CommandsImplementation;

namespace TelegramShell.Tests
{
    public class ListOfCommandsTestShould
    {
        [Fact]
        public void ReturnsAStringWithAllComands()
        {
            ShowImplementation commands = new ShowImplementation();
            commands.Execute().Should().Be("/Show\n/Cmd\n/Chat\n/QuitChat\n");
        }
    }
}
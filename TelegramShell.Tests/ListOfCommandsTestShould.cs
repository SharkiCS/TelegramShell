using Xunit;
using FluentAssertions;

namespace TelegramShell.Tests
{
    public class ListOfCommandsTestShould
    {
        [Fact]
        public void ReturnsAStringWithAllComands()
        {
            ListOfCommands commands = new ListOfCommands();
            commands.Show().Should().Be("/Show\n/Cmd\n/Chat\n/QuitChat\n");
        }
    }
}
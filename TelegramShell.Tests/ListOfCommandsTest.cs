using Xunit;
using FluentAssertions;

namespace TelegramShell.Tests
{
    public class ListOfCommandsTest
    {
        [Fact]
        public void ShowReturnsAStringWithAllComands()
        {
            ListOfCommands commands = new ListOfCommands();
            commands.Show().Should().Be(
                "/Show\n/Cmd\n"
                );
        }
    }
}
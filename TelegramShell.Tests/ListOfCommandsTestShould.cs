using Xunit;
using FluentAssertions;

namespace TelegramShell.Tests
{
    public class ListOfCommandsTestShould
    {
        [Fact]
        public void ReturnsAStringWithAllComands()
        {
            Show commands = new Show();
            commands.Execute().Should().Be("/Show\n/Cmd\n/Chat\n/QuitChat\n");
        }
    }
}
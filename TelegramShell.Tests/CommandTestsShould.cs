using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;

namespace TelegramShell.Tests
{
    public class CommandTestsShould
    {
        [Fact]
        public void ReturnTheCommandEnumIfExists()
        {
            Command command = new Command("/Cmd echo 1");
            command.GetCommand().Should().Be(Commands.Cmd);
        }
        
        [Fact]
        public void ReturnNotValidCommandIfDoesntExist()
        {
            Command command = new Command("/testing");
            command.GetCommand().Should().Be(Commands.NotValidCommand);
        }
        
        [Fact]
        public void ReturnsAnArrayWithOnlyTheParameters()
        {
            Command command = new Command("/Cmd echo 1");
            command.GetParameters().Should().Equal( new List<String>() {"echo", "1"});
        }

        [Fact]
        public void ReturnTheCommandName()
        {
            Show show = new();
            show.IsMatch().Should().Be("Show");
        }
    }
}
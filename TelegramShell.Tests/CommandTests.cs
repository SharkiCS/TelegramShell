using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;

namespace TelegramShell.Tests
{
    public class CommandTests
    {
        [Fact]
        public void GetCommandReturnTheCommandEnumIfExists()
        {
            Command command = new Command("/Cmd echo 1");
            command.GetCommand().Should().Be(Commands.Cmd);
        }
        
        [Fact]
        public void GetCommandReturnNotValidCommandIfDoesntExist()
        {
            Command command = new Command("/testing");
            command.GetCommand().Should().Be(Commands.NotValidCommand);
        }
        
        [Fact]
        public void GetParametersReturnsAnArrayWithOnlyTheParameters()
        {
            Command command = new Command("/Cmd echo 1");
            command.GetParameters().Should().Equal( new List<String>() {"echo", "1"});
        }
    }
}
using System;
using Xunit;
using FluentAssertions;

namespace TelegramShell.Tests
{
    public class EnvFileTestsShould
    {
        private readonly String _path = @"FakeEnviroments\.env";
        
        [Fact]
        public void ReturnsTheEnviroments()
        {
            EnvFile envFile = new(_path);
            envFile.Load();

            Environment.GetEnvironmentVariable("testing").Should().Be("PATATA");
        }
    }
}
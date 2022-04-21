using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TelegramShell
{
    public class EnvFile
    {
        private readonly string _path;

        public EnvFile(string path) => _path = path;

        public void Load()
        {
            if (!File.Exists(_path))
                return;

            foreach (var line in File.ReadAllLines(_path))
            {
                List<string> parts = line.Split('=').ToList();
                Environment.SetEnvironmentVariable(parts.First(), parts.Last());
            }
        }
    }
}
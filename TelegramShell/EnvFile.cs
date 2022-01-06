using System;
using System.IO;

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
                var parts = line.Split(
                    '=',
                    StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length != 2)
                    continue;
                
                Environment.SetEnvironmentVariable(parts[0], parts[1]);
            }
        }
    }
}
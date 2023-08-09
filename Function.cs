﻿namespace CreeperSharp
{
    public class Function
    {
        string path = "";
        public Function(string path, string contents = "")
        {
            FileOrganizer FO = new FileOrganizer();
            this.path = path;
            if (!File.Exists(path))
            {
                FO.CreateFullDirectory(path, true);
                Console.WriteLine($"Created {path}");
            } else
            {
                Console.WriteLine($"Extended {path}");
            }
            Thread.Sleep(10);
            File.WriteAllText(path, contents);
        }
        public void AddCommand(string command)
        {
            string content = File.ReadAllText(this.path);
            content = content + command;
            File.WriteAllText(this.path, content);
        }
        public bool WriteAllCommands(string[] commands)
        {
            try
            {
                string content = File.ReadAllText(this.path);
                foreach (string command in commands)
                {
                    content = content + "\n" + command;
                }
                File.WriteAllText(this.path, content);
                return true;
            } catch(IOException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}

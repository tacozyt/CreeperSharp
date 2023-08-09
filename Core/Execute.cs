﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreeperSharp.Core
{
    public class Execute
    {
        const string[] defaults = null;
        public string Write(string execute, string[] commands = defaults)
        {
            string allCommands = "";
            foreach (string command in commands)
            {
                allCommands += "execute " + execute + "run " + command + "\n";
            }
            return allCommands;
        }
        public string As(string selector, string addition = "")
        {
            return "as " + selector + " " + addition;
        }
        public string At(string selector, string addition = "")
        {
            return "at " + selector + " " + addition;
        }
        public string Asat(string selector, string addition = "")
        {
            return "as " + selector + " " + "at " + selector + " " + addition;
        }
        public string Unless(string arguments, string addition = "")
        {
            return "unless " + arguments + " " + addition;
        }
        public string If(string arguments, string addition = "")
        {
            return "if " + arguments + " " + addition;
        }
        public string Summon(string entity, string[] pos, string addition = "")
        {
            return "summon " + entity + " " + pos[0] + " " + pos[1] + " " + pos[2] + " " + addition;
        }
    }
}

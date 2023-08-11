﻿namespace SteveSharp.Core
{
    public class Entity
    {
        public string Self = "@s";
        public string Everyone = "@a";
        public string Random = "@r";
        public string Closest = "@p";
        public string Teleport(string selector, string to)
        {
            return $"tp {selector} {to}";
        }
        public string Summon(string entity, string[] pos, string nbt = "{}")
        {
            return $"summon {entity} {pos} {nbt}";
        }
        public string AddTag(string selector, string tag)
        {
            return $"tag {selector} add {tag}";
        }
        public string RemoveTag(string selector, string tag)
        {
            return $"tag {selector} remove {tag}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TakapoWebSite.Models
{
    public class KeyValueModel
    {
        public KeyValueModel(string key, string value)
        {
            Key = key;
            Value = value;
        }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}

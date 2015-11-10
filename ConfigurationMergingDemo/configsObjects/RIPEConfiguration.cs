using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationMergingDemo.configsObjects
{
    public class RIPEConfiguration
    {
        public string Pass { get; set;}

        public string Host { get; set;}

        public string Source { get; set; }

        public InetnumElement Inetnum { get; set; }
    }
}

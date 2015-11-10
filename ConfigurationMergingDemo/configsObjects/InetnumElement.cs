using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationMergingDemo.configsObjects
{
    public class InetnumElement
    {
        public string ChangedEmail { get; set; }

        public string NetNamePattern { get; set; }

        public string EmptyNetNamePattern { get; set; }

        public string PersonNetDescr { get; set; }

        public string EmptyNetDescr { get; set; }

        public List<DefaultParam> Defaults { get; set; }
    }
}

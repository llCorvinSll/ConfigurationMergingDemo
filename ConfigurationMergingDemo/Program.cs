using ConfigurationMergingDemo.configsObjects;
using Microsoft.Framework.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationMergingDemo
{
    class Program
    {
        static List<DefaultParam> singleConfig(string confPath)
        {
            var confBuild = new ConfigurationBuilder();

            confBuild
                .AddXmlFile(confPath);

            var conf = confBuild.Build();


            var bindedConfig = conf.Get<RIPEConfiguration>("RIPESection");

            return bindedConfig.Inetnum.Defaults;
        }

        static List<DefaultParam> mergedConfig()
        {
            var confBuild = new ConfigurationBuilder();

            confBuild
                .AddXmlFile("configs/main.xml")
                .AddXmlFile("configs/second.xml");

            var conf = confBuild.Build();


            var bindedConfig = conf.Get<RIPEConfiguration>("RIPESection");

            return bindedConfig.Inetnum.Defaults;
        }

        static void Main(string[] args)
        {

            var mainSet = singleConfig("configs/main.xml");
            var secondSet = singleConfig("configs/second.xml");

            var mergeSet = mergedConfig();


            Console.WriteLine(@"Expected number of nodes after merging = secondSet {0}  but = {1}",
                secondSet.Count(),
                mergeSet.Count()
                );


            Console.WriteLine(@"Expected ""Name"" attr of Node Mapped to object and dont empty {0}", 
                !String.IsNullOrEmpty(mergeSet.First().Name));

            Console.ReadKey();
        }
    }
}

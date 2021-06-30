using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace functional
{
    class TestFlatMap
    {

        public static void Main(String[] args)
        {
            List<Developer> team = new List<Developer>();

            Developer polyglot = new Developer("esoteric");
            polyglot.Add("clojure");
            polyglot.Add("scala");
            polyglot.Add("groovy");
            polyglot.Add("go");
            
            Developer busy = new Developer("pragmatic");
            busy.Add("java");
            busy.Add("javascript");
            
            
            team.Add(polyglot);
            team.Add(busy);

            List<string> teamLanguages = team.Select(x => x.GetLanguages()).ToList();
            Console.WriteLine(teamLanguages);
        }

    }
}

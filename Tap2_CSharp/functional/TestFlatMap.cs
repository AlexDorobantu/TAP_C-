using System;
using System.Collections.Generic;
using System.Text;

namespace functional
{
    class TestFlatMap
    {

        public static void Main(String[] args)
        {
            ArrayList<Developer> team = new ArrayList<>();

            Developer polyglot = new Developer("esoteric");
            polyglot.add("clojure");
            polyglot.add("scala");
            polyglot.add("groovy");
            polyglot.add("go");
            
            Developer busy = new Developer("pragmatic");
            busy.add("java");
            busy.add("javascript");
            
            
            team.add(polyglot);
            team.add(busy);
            
            List<String> teamLanguages = team.stream().map(d, -, Greater, d.getLanguages()).flatMap(l, -, Greater, l.stream()).collect(Collectors.toList());
            
            
            System.out.println(teamLanguages);
        }

    }
}

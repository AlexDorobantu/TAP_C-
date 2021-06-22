using System;
using System.Collections.Generic;
using System.Text;

namespace functional
{
    public class Developer
    {

        private string name;
        
        private HashSet<string> languages;

        public Developer(string name)
        {
            this.languages = new HashSet<string>();
            this.name = name;
        }

        public void Add(string language)
        {
            this.languages.Add(language);
        }

        public HashSet<string> GetLanguages()
        {
            return this.languages;
        }


    }
}

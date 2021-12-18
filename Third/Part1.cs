using System.Collections.Generic;
using System.Collections.Immutable;

namespace Third
{ 
    class Part1
    {
        public ImmutableList<string> Poem { get; set; }

        public ImmutableList<string> AddPart(ImmutableList<string> list)
        {
            Poem = list.Add("Вот дом,");
            Poem = Poem.Add("Который построил Джек.");
            return Poem;

        }
    }

}

using System.Collections.Generic;
using System.Collections.Immutable;

namespace Third
{
    class Part2
    {
        public ImmutableList<string> Poem { get; set; }

        public ImmutableList<string> AddPart(ImmutableList<string> list)
        {
            Poem = list.Add("А это пшеница,");
            Poem = Poem.Add("Которая в темном чулане хранится");
            Poem = Poem.Add("В доме,");
            Poem = Poem.Add("Который построил Джек.");

            return Poem;
        }
    }
}




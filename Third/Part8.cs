using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    class Part8
    {
        public ImmutableList<string> Poem { get; set; }

        public ImmutableList<string> AddPart(ImmutableList<string> list)
        {
            Poem = list.Add("А это ленивый и толстый пастух,");
            Poem = Poem.Add("Который бранится с коровницей строгою,");
            Poem = Poem.Add("Которая доит корову безрогую,");
            Poem = Poem.Add("Лягнувшую старого пса без хвоста,");
            Poem = Poem.Add("Который за шиворот треплет кота,");
            Poem = Poem.Add("Который пугает и ловит синицу,");
            Poem = Poem.Add("Которая часто ворует пшеницу,");
            Poem = Poem.Add("Которая в темном чулане хранится");
            Poem = Poem.Add("В доме,");
            Poem = Poem.Add("Который построил Джек.");
            return Poem;
        }
    }
}

using System;
using System.Collections.Immutable;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            ImmutableList<string> storage = ImmutableList.Create<string>();
            var part1 = new Part1();
            var part2 = new Part2();
            var part3 = new Part3();
            var part4 = new Part4();
            var part5 = new Part5();
            var part6 = new Part6();
            var part7 = new Part7();
            var part8 = new Part8();
            var part9 = new Part9();

            part9.AddPart(
                part8.AddPart(
                    part7.AddPart(
                        part6.AddPart(
                            part5.AddPart(
                                part4.AddPart(
                                    part3.AddPart(
                                        part2.AddPart(
                                            part1.AddPart(storage)))))))));

            ConsoleOutput(part1.Poem);
            ConsoleOutput(part2.Poem);
            ConsoleOutput(part3.Poem);
            ConsoleOutput(part4.Poem);
            ConsoleOutput(part5.Poem);
            ConsoleOutput(part6.Poem);
            ConsoleOutput(part7.Poem);
            ConsoleOutput(part8.Poem);
            ConsoleOutput(part9.Poem);

            Console.ReadLine();
        }
        public static void ConsoleOutput(ImmutableList<string> collection)
        {
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine();
        }
    }
}

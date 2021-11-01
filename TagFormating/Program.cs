using System;

namespace TagFormating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Tagy:
Capital <cap>
Exclamation <exc>
Dot <dot>
Underscore <und>
Bracket <bra>
Ukončení tagu: </...>
Zadaný text s tagy: ");          
            string text = Console.ReadLine();

            Tags Capital = new Tags("cap");
            Tags Exclamation = new Tags("exc");
            Tags Dot = new Tags("dot");
            Tags Underscore = new Tags("und");
            Tags Bracket = new Tags("bra");

            foreach (Tags tagger in Tags.TagList)
            {
                int i = text.IndexOf(tagger.Name);

                if (i == -1)
                {
                    continue;
                }

                if (text.Substring(i - 1, 5) == '<' + tagger.Name + '>')
                {
                    int j = text.IndexOf(tagger.Name, i+1);
                    if (j == -1)
                    {
                        continue;
                    }

                    if (text.Substring(j - 2, 6) == "</" + tagger.Name + '>')
                    {
                        string tagText = Tags.Formatting(text.Substring(i + 4, j - i - 6), tagger.Name);

                        text = text.Substring(0, i - 1) + tagText + text.Substring(j + 4);
                    }
                }
            }
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}

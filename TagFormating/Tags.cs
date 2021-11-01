using System;
using System.Collections.Generic;
using System.Text;

namespace TagFormating
{
    class Tags
    {
        public static List<Tags> TagList = new List<Tags>();

        public Tags(string n)
        {
            Name = n;
            TagList.Add(this);
        }

        public static string Formatting(string text, string tag)
        {
            string tagText = "";
            //Tags Capital, Exclamation, Dot, Underscore, Bracket
            if (tag == "cap")
            {
                tagText = text.ToUpper();
                return tagText;
            }

            if (tag == "exc")
            {
                tagText = "!" + text + "!";
                return tagText;
            }

            if (tag == "dot")
            {
                tagText = "." + text + ".";
                return tagText;
            }

            if (tag == "und")
            {
                tagText = "_" + text + "_";
                return tagText;
            }

            if (tag == "bra")
            {
                tagText = "(" + text + ")";
                return tagText;
            }

            else
            {
                return tagText;
            }
        }

        public string Name
        {
            get; private set;
        }        
    }
}
